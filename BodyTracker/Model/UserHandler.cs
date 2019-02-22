using System.Collections.ObjectModel;

namespace BodyTracker.Model
{
    class UserHandler
    {
        private ObservableCollection<User> _users = new ObservableCollection<User>(){ new User("Morten"), new User("Lucas")};

        public ObservableCollection<User> Users
        {
            get { return _users; }
            set { _users = value; }
        }
    }
}
