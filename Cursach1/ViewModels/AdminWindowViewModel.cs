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
        private readonly string _title = "AdminWindow";

        public ICommand BackToLogin => new OpenPreviousWindowCommand(_title);
    }
}
