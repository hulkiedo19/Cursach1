using Cursach1.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cursach1.ViewModels
{
    public class LoginViewModel : ViewModel
    {
        private string _username;
        private string _password;

        public ICommand LoginCommand => new LoginCommand(this);

        public string Username
        {
            get => _username;
            set => Set(ref _username, value, nameof(Username));
        }

        public string Password
        {
            get => _password;
            set => Set(ref _password, value, nameof(Password));
        }
    }
}
