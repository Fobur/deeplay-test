using MongoDB.Bson.Serialization.Attributes;

namespace deeplay_test
{
    public class Human
    {
        [BsonElement]
        public string Name { get; set; }
        [BsonElement]
        public string Surname { get; set; }
        [BsonElement]
        public string Patronymic { get; set; }
        [BsonElement]
        public DateTime DateOfBirth { get; set; }
        [BsonElement]
        public string Sex { get; set; }
   
        public Human(string fullName, DateTime dateOfBirth, string sex)
        {
            var splitName = fullName.Split(' ');
            Surname = splitName[0];
            Name = splitName[1];
            Patronymic = splitName[2];
            DateOfBirth = dateOfBirth;
            Sex = sex;
        }

        [BsonConstructor]
        public Human(string name, string surname, string patronymic,
            DateTime dateOfBirth, string sex)
        {
            Name = name;
            Patronymic = patronymic;
            Surname= surname;
            DateOfBirth= dateOfBirth;
            Sex= sex;
        }

        public void Edit(HumanFields field, string newValue)
        {
            switch (field)
            {
                case HumanFields.Name:
                    Name = newValue; break;
                case HumanFields.Sername:
                    Surname = newValue; break;
                case HumanFields.Patronymic:
                    Patronymic = newValue; break;
                case HumanFields.DateOfBirth:
                    DateOfBirth = DateTime.Parse(newValue); break;
                case HumanFields.Sex:
                    Sex = newValue; break;
            }
        }

        public string GetFullName()
        {
            return $"{Surname} {Name} {Patronymic}";
        }
    }

    public enum HumanFields
    {
        Name,
        Sername,
        Patronymic,
        DateOfBirth,
        Sex
    }

    public enum Sexes
    {
        Женский,
        Мужской
    }
}
