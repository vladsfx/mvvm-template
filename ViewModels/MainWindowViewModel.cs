using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MVVM.ViewModels.Base;

namespace MVVM.ViewModels
{
    public class MainWindowViewModel : TitleViewModel
    {
        public MainWindowViewModel()
        {
            Title = "Главное окно";
        }
    }
}
