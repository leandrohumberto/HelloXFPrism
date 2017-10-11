using Prism.Navigation;
using HelloXFPrism.ViewModels.BaseViewModels;
using System;

namespace HelloXFPrism.ViewModels
{
    public class ThirdChildPageViewModel : ChildViewModelBase, INavigationAware
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
        
        public ThirdChildPageViewModel()
        {

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {

        }

        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("third"))
                Text = parameters.GetValue<string>("third");
        }

        private void HandleIsActiveTrue(object sender, EventArgs args)
        {
            if (IsActive == false)
                return;

            // Handle Logic Here
        }

        private void HandleIsActiveFalse(object sender, EventArgs args)
        {
            if (IsActive == true)
                return;

            // Handle Logic Here
        }
    }
}
