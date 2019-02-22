using System;

namespace BodyTracker.Model
{
    class User
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }
        public double FatPercentage { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
        public DateTime LastLogon { get; set; }
        public DateTime Birthday { get; set; }

        public User(string name, string gender, double weight, double fatPercentage, double height, int age, DateTime birthday)
        {
            Name = name;
            Gender = gender;
            Weight = weight;
            FatPercentage = fatPercentage;
            Height = height;
            Age = age;
            Birthday = birthday;
        }

        public User(string name)
        {
            Name = name;
        }
    }
}
