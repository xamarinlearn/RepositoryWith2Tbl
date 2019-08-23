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
