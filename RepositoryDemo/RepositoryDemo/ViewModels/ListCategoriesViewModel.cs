using RepositoryDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using RepositoryDemo.Services;
using Xamarin.Forms;

namespace RepositoryDemo.ViewModels
{
 public  class ListCategoriesViewModel
    {
        private readonly ICategoryRepository repository;

      
        public ListCategoriesViewModel(ICategoryRepository repository )
        {
            this.repository = repository;
            Categories = new List<Category>
                (((CategoryRepositorySqlite)repository).GetCategoriesWithChildren());

            ShowProductosOfCategorySelectedCommand = new Command(ShowProducts);
            Products = new ObservableCollection<Product>();
        }

        private void ShowProducts()
        {
            Products.Clear();

            foreach (Product product in SelectedCategory.Products)
            {
                Products.Add(product);
            }
        }
        #region Properties
        public List<Category> Categories { get; set; }
        public Category SelectedCategory { get; set; }
        public ObservableCollection<Product> Products { get; set; }
        #endregion

        #region Commands
        public Command ShowProductosOfCategorySelectedCommand { get; set; }
        #endregion

        #region Private Methods

        #endregion
    }
}
