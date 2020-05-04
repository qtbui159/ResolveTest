using Prism.Mvvm;
using ResolveTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolveTest.ViewModels
{
    class MainWindowViewModel : BindableBase
    {
        public Number NewObj { get; private set; }
        public Number ResolveObj { get; private set; }

        public MainWindowViewModel(INumberService numberService)
        {
            NewObj = new Number(numberService, 1, 2, 3, 4);
            ResolveObj = Number.Create(1, 2, 3, 4);
        }
    }
}
