using RepositoryDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using RepositoryDemo.Services;

namespace RepositoryDemo.ViewModels
{
 public  class ListCategoriesViewModel
    {
        private readonly ICategoryRepository repository;

      
        public ListCategoriesViewModel(ICategoryRepository repository )
        {
            this.repository = repository;

        }
        #region Properties
        public List<Category> Categories { get; set; }
        public Category SelectedCategory { get; set; }

        #endregion

        #region Commands

        #endregion

        #region Private Methods

        #endregion
    }
}
