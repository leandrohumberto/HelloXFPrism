using HelloXFPrism.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace HelloXFPrism.ViewModels
{
    public class ListItemPageViewModel : BindableBase
    {
        private INavigationService _navigationService;

        private ObservableCollection<ListViewModel.ListViewItem> _listItems;

        public IEnumerable<ListViewModel.ListViewItem> ListItems => _listItems;

        public DelegateCommand<object> NavigateToDetailCommand => new DelegateCommand<object>(NavigateToDetail);

        public ListItemPageViewModel()
        {
            _listItems = ListViewModel.GetListItems();
        }

        public ListItemPageViewModel(INavigationService navigationService)
            : this()
        {
            _navigationService = navigationService;
        }

        private async void NavigateToDetail(object param)
        {
            await _navigationService.NavigateAsync("ItemDetailPage", 
                new NavigationParameters() { { "item", (param as ListViewModel.ListViewItem) } } );
        }
    }
}
