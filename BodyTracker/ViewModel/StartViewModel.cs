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

        public RelayCommand CreateUserCommand {get; set;}
        public RelayCommand ChooseUserCommand {get; set;}

        public StartViewModel()
        {
            CreateUserCommand = new RelayCommand(UserHandler.CreateUser);
            ChooseUserCommand = new RelayCommand(UserHandler.ChooseUser);
        }

    }
}
