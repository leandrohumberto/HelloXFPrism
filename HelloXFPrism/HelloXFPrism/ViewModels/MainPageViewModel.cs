using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloXFPrism.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware, IConfirmNavigation
    {
        private INavigationService _navigationService;

        public DelegateCommand NavigateToSpeakPageCommand { get; private set; }

        public DelegateCommand NavigateToListItemPageCommand { get; private set; }

        public DelegateCommand NavigateToTabbedPageCommand { get; private set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainPageViewModel()
        {
            
        }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateToSpeakPageCommand = new DelegateCommand(NavigateToSpeakPage);
            NavigateToListItemPageCommand = new DelegateCommand(NavigateToListItemPage);
            NavigateToTabbedPageCommand = new DelegateCommand(NavigateToTabbedPage);
        }

        private async void NavigateToTabbedPage()
        {
            var navParams = new NavigationParameters("first=First&second=Second&third=Third");
            await _navigationService.NavigateAsync("PrismTabbedPage", navParams);
        }

        private async void NavigateToListItemPage()
        {
            await _navigationService.NavigateAsync("ListItemPage");
        }

        private async void NavigateToSpeakPage()
        {
            await _navigationService.NavigateAsync("SpeakPage", new NavigationParameters("code=CR&desc=Red"));
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }

        public bool CanNavigate(NavigationParameters parameters)
        {            
            System.Diagnostics.Debug.WriteLine($"{GetType().FullName}.CanNavigate");

            foreach (var key in parameters.Keys)
            {
                System.Diagnostics.Debug.WriteLine($"{key} => {parameters[key]} ({parameters[key].GetType()})");
            }

            parameters.Add("CanNavigate", true);

            return true;
        }
    }
}
