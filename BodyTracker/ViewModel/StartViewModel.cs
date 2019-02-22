using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyTracker.Model;
using GalaSoft.MvvmLight.Command;

namespace BodyTracker.ViewModel
{
    class StartViewModel
    {
        public UserHandler UserHandler { get; set; } = new UserHandler();

        public RelayCommand CreateUserPopupCommand {get; set;}
        public RelayCommand ChooseUserCommand {get; set;}
        public RelayCommand CreateNewUserCommand { get; set; }

        public StartViewModel()
        {
            CreateUserPopupCommand = new RelayCommand(UserHandler.CreateUserPopup);
            ChooseUserCommand = new RelayCommand(UserHandler.ChooseUser);
            CreateNewUserCommand = new RelayCommand(UserHandler.CreateNewUser);
        }

    }
}
