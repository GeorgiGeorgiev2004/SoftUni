namespace PersonInfo
{
    using System;

    public class Citizen : IPerson,IBirthable,IIdentifiable
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace");
                }
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be less than zero");
                }
                age = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Id cannot be null or whitespace");
                }
                id = value;
            }
        }

        public string Birthdate
        {
            get
            {
                return birthdate;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Birthdate cannot be null or whitespace");
                }
                birthdate = value;
            }
        }
    }
}
