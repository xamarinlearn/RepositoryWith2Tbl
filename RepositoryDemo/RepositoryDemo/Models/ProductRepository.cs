using System;
using System.Collections.Generic;
using System.Text;
using RepositoryDemo.Services;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace RepositoryDemo.Models
{
    public class ProductRepositorySqlite : IRepositoryProduct
    {
        public string MessageStatus { get; set; }
        SQLiteConnection conn;
        public ProductRepositorySqlite(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Product>();
        }
        public void AddNewProduct(Product newProduct)
        {
            try
            {
                
                conn.Insert(newProduct); //
                MessageStatus = 
                    $"Registro ingresado. Product Id: {newProduct.Id}, Name: {newProduct.ProductName}";
            }
            
            catch (Exception ex)
            {

                MessageStatus = $"Error al guardar registro. Error: {ex.Message}";
            }

        }

        public List<Product> Get()
        {
            return conn.Table<Product>().ToList();
        }

        public bool UpdateProduct(Product productToUpdate)
        {
            return conn.Update(productToUpdate)>1;
        }
    }
}
