using System;

namespace BodyTracker.Model
{
    class User
    {
        public string Name { get; set; }
        public DateTime LastLogin { get; set; } = DateTime.Now;

        public User(string name)
        {
            Name = name;
        }
    }
}
