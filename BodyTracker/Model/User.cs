using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyTracker.Model
{
    class User
    {
        private string _name;
        private double _weight;
        private DateTime _lastLogon;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime LastLogon
        {
            get { return _lastLogon; }
            set { _lastLogon = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public User(string name)
        {
            Name = name;
        }
    }
}
