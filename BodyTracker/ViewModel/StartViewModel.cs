using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyTracker.Model;

namespace BodyTracker.ViewModel
{
    class StartViewModel
    {
        private UserHandler _userHandler = new UserHandler();

        public UserHandler UserHandler
        {
            get { return _userHandler; }
            set { _userHandler = value; }
        }
    }
}
