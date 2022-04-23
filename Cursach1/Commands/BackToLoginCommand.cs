using Cursach1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cursach1.Commands
{
    public class BackToLoginCommand : Command
    {
        public override void Execute(object parameter)
        {
            var command = new OpenCloseWindowCommand(new LoginWindow(), Application.Current.MainWindow);
            command.Execute(parameter);
        }
    }
}
