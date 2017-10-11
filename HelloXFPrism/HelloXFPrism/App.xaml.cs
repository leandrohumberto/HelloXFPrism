using Prism.Unity;
using HelloXFPrism.Views;
using Xamarin.Forms;

namespace HelloXFPrism
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("NavigationPage/MainPage?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<SpeakPage>();
            Container.RegisterTypeForNavigation<ListItemPage>();
            Container.RegisterTypeForNavigation<ItemDetailPage>();
            Container.RegisterTypeForNavigation<PrismTabbedPage>();
            Container.RegisterTypeForNavigation<FirstChildPage>();
            Container.RegisterTypeForNavigation<SecondChildPage>();
            Container.RegisterTypeForNavigation<ThirdChildPage>();
        }
    }
}
