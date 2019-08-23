using RepositoryDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryDemo.Services
{
   public interface ICategoryRepository
    {
        void AddNewCategory(Category newCategory);

        List<Category> GetCategories();
    }
}
