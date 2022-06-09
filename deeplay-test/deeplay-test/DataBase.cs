using MongoDB.Bson;
using MongoDB.Driver;

namespace deeplay_test
{
    internal static class DataBase
    {
        static string DBName = "EmployeeDataBase";
        static string ConnectionString = "mongodb://localhost:27017";
        static MongoClient Client = new MongoClient(ConnectionString);
        static IMongoDatabase Database = Client.GetDatabase(DBName);
        static IMongoCollection<Employee> Collection = Database.GetCollection<Employee>("Employees");

        public static async Task Delete(Employee employee)
        {
            await Collection.DeleteOneAsync(new BsonDocument("_id", employee.Id));
        }

        public static async Task Add(Employee employee)
        {
            await Collection.InsertOneAsync(employee);
        }

        public static async Task Update(Employee employee)
        {
            await Collection.ReplaceOneAsync(new BsonDocument("_id", employee.Id), employee);
        }

        public static async Task<IAsyncCursor<Employee>> Filter (BsonDocument filter)
        {
            return await Collection.FindAsync(filter); ;
        }

        public static async Task<string[]> GetArrayOfSupervisorsByJobTitle(string jobTitle)
        {
            var filter = new BsonDocument
                    {{
                        "JobTitle", new BsonDocument
                        {{
                                "Title", jobTitle
                        }}
                    }};
            var filtered = await Filter(filter);
            var listOfSupervisor = new List<string> { "Нет руководителя" };
            if (filtered.Current != null)
            {
                while (await filtered.MoveNextAsync())
                {
                    var current = filtered.Current;
                    foreach (var employee in current)
                    {
                        listOfSupervisor.Add(employee.Personality.GetFullName());
                    }
                }
            }
            return listOfSupervisor.ToArray();
        }
    }
}
