using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace BodyTracker.Model
{
    class UserHandler
    {
        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>(){ new User("Morten"), new User("Lucas")};

        public User SelectedUser { get; set; }
        public User CurrentUser;

        public void ChooseUser()
        {
            if (SelectedUser != null)
            {
                CurrentUser = SelectedUser;
                Frame currentFrame = Window.Current.Content as Frame;
                currentFrame?.Navigate(typeof(MainPage));
            }
        }

        public void CreateUser()
        {
            Debug.WriteLine("CreateUser");
        }
    }
}
