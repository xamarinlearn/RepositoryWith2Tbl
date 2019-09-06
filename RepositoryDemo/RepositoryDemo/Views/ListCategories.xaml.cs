using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepositoryDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListCategories : ContentPage
    {
        public ListCategories()
        {
            InitializeComponent();
            BindingContext =
               new ViewModels.ListCategoriesViewModel
               (new Models.CategoryRepositorySqlite
               (Path.Combine(Environment.GetFolderPath
               (Environment.SpecialFolder.LocalApplicationData), "Nwdb.db")));
        }

     
    }
}