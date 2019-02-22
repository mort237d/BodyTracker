using System;

namespace BodyTracker.Model
{
    class User
    {
        public string Name { get; set; }

        public DateTime LastLogon { get; set; }

        public double Weight { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }
}
