using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloXFPrism.ViewModels
{
    public class PrismTabbedPageViewModel : BindableBase, INavigatingAware
    {
        public PrismTabbedPageViewModel()
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            
        }
    }
}
