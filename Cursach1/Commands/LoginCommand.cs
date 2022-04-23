using Cursach1.ViewModels;
using Cursach1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cursach1.Commands
{
    public class LoginCommand : Command
    {
        private readonly string UserLogin = "user";
        private readonly string UserPassword = "user";
        private readonly string AdminLogin = "admin";
        private readonly string AdminPassword = "admin";
        private LoginViewModel _viewModel;

        public LoginCommand(LoginViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
            if (UserLogin == _viewModel.Username && UserPassword == _viewModel.Password)
            {
                var command = new OpenCloseWindowCommand(new UserWindow(), Application.Current.MainWindow);
                command.Execute(parameter);
            } 
            else if(AdminLogin == _viewModel.Username && AdminPassword == _viewModel.Password)
            {
                var command = new OpenCloseWindowCommand(new AdminWindow(), Application.Current.MainWindow);
                command.Execute(parameter);
            } 
            else
            {
                //
            }
        }
    }
}
