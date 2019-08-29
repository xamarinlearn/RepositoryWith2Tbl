using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using RepositoryDemo.Models;
using RepositoryDemo.Services;
using Xamarin.Forms;

namespace RepositoryDemo.ViewModels
{
  public class AddCategoryViewModel
    {
        ICategoryRepository Repository;
        public AddCategoryViewModel(ICategoryRepository repository)
        {
            Repository = repository;

            AddProductCommand = new Command(AddProductToProductsCollection);
            SaveCategoryCommand = new Command(SaveNewCategory);

            Products = new ObservableCollection<Product>();
        }

        private void SaveNewCategory()
        {
            Category C = new Category
            {
                CategoryName = CategoryName,
                Description = Description
            };
            C.Products = new List<Product>(Products);

            Repository.AddNewCategory(C);
        }

        private void AddProductToProductsCollection()
        {
            Products.Add(new Product // TODO: detalle.
            { ProductName = TextProductName,
                Price =0,UnitsInStock=0
            });
        }

        #region Properties
        public ObservableCollection<Product> Products { get; set; }
        public string CategoryName { get; set; }
        public string TextProductName { get; set; }

        public string Description { get; set; }
        #endregion

        #region Commands
        public Command AddProductCommand { get; set; }
        public Command SaveCategoryCommand { get; set; }
        #endregion
    }
}
