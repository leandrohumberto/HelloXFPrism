using System;
using Prism.Navigation;
using Xamarin.Forms;
using Prism.Common;

namespace HelloXFPrism.Views
{
    public partial class PrismTabbedPage : TabbedPage, INavigatingAware
    {
        public PrismTabbedPage()
        {
            InitializeComponent();
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            foreach (var child in Children)
            {
                PageUtilities.OnNavigatingTo(child, parameters);
            }
        }
    }
}
