using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloXFPrism.ViewModels
{
    public class ItemDetailPageViewModel : BindableBase, INavigationAware
    {
        private Models.ListViewModel.ListViewItem _item;

        public Models.ListViewModel.ListViewItem Item
        {
            get { return _item; }
            set { SetProperty(ref _item, value); }
        }

        public ItemDetailPageViewModel()
        {

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.Keys.Contains("item"))
                Item = parameters["item"] as Models.ListViewModel.ListViewItem;
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            
        }
    }
}
