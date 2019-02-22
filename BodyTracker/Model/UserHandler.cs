using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using BodyTracker.Annotations;

namespace BodyTracker.Model
{
    class UserHandler : INotifyPropertyChanged
    {
        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>(){ new User("Morten"), new User("Lucas")};

        public User SelectedUser { get; set; }
        public User CurrentUser;

        public string CreateUserName { get; set; }
        public string CreateUserWeight { get; set; }

        private bool _createUserPopUp = false;


        #region Metoder
        public void ChooseUser()
        {
            if (SelectedUser != null)
            {
                CurrentUser = SelectedUser;
                Frame currentFrame = Window.Current.Content as Frame;
                currentFrame?.Navigate(typeof(MainPage));
            }
        }

        public void CreateUserPopup()
        {
            CreateUserPopUp = true;
        }

        public void CreateNewUser(string name, double weight)
        {

        }
        #endregion

        #region Properties
        public bool CreateUserPopUp
        {
            get => _createUserPopUp;
            set
            {
                _createUserPopUp = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
