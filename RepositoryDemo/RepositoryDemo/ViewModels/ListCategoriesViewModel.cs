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
          
        }

        private void ShowProducts()
        {
            Products.Clear();

            Products = new List<Product>(SelectedCategory.Products);
        }
        #region Properties
        public List<Category> Categories { get; set; }
        public Category SelectedCategory { get; set; }
        public List<Product> Products { get; set; }
        #endregion

        #region Commands
        public Command ShowProductosOfCategorySelectedCommand { get; set; }
        #endregion

        #region Private Methods

        #endregion
    }
}
