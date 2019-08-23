using System;
using System.Collections.Generic;
using System.Text;
using RepositoryDemo.Models;

namespace RepositoryDemo.Services
{
  public  interface IRepositoryProduct
    {
        void AddNewProduct(Product newProduct);
        List<Models.Product> Get();

        bool UpdateProduct(Product productToUpdate);

    }
}
