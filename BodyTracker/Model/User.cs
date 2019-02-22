﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyTracker.Model
{
    class User
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public User(string name)
        {
            Name = name;
        }
    }
}
