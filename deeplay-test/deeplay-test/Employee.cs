using MongoDB.Bson.Serialization.Attributes;

namespace deeplay_test
{
    public class Employee
    {
        [BsonId]
        public readonly int Id;
        [BsonElement]
        public readonly Human Personality;
        [BsonElement]
        internal JobTitle JobTitle { get;}

        public Employee(string name, DateTime dateOfBirth, string sex,
            string jobTitle, string jobInformation, int id)
        {
            Id = id;
            Personality = new Human(name, dateOfBirth, sex);
            JobTitle = new JobTitle(jobTitle, jobInformation);
        }

        [BsonConstructor]
        public Employee(int id, Human personality, JobTitle jobTitle)
        {
            Id = id;
            Personality = personality;
            JobTitle = jobTitle;
        }
    }

    public class JobTitle
    {
        [BsonElement]
        public readonly string Title;
        [BsonElement]
        public readonly string Information;

        [BsonConstructor]
        public JobTitle(string title, string information)
        {
            Title = title;
            Information = information;
        }
    }
}
