using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloXFPrism.Models
{
    public class ListViewModel
    {
        public static ObservableCollection<ListViewItem> GetListItems()
        {
            return new ObservableCollection<ListViewItem>
            {
                new ListViewItem { FirstName = "Marcos", LastName = "Russo", }, 
                new ListViewItem { FirstName = "Rogério", LastName = "Mendes", }, 
                new ListViewItem { FirstName = "Milton", LastName = "Ramalho", }, 
                new ListViewItem { FirstName = "Célio", LastName = "Lopes", }, 
                new ListViewItem { FirstName = "Alceu", LastName = "Braga", },
            };
        }

        public class ListViewItem
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
