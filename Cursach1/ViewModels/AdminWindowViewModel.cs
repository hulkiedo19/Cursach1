using Cursach1.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cursach1.ViewModels
{
    public class AdminWindowViewModel : ViewModel
    {
        public ICommand BackToLogin => new BackToLoginCommand();
    }
}
