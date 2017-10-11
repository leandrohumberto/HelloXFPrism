using Xamarin.Forms;

namespace HelloXFPrism.Views
{
    public partial class ListItemPage : ContentPage
    {
        public ListItemPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (sender is ListView)
                (sender as ListView).SelectedItem = null;
        }
    }
}
