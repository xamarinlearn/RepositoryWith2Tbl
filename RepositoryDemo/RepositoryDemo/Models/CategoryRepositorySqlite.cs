using RepositoryDemo.Services;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace RepositoryDemo.Models
{
   public class CategoryRepositorySqlite : ICategoryRepository
    {
        public string MessageStatus { get; set; }
        SQLiteConnection conn;

        public CategoryRepositorySqlite( string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Category>();
            conn.CreateTable<Product>();
        }

        // TODO: Este método debe guardar objetos con hijos
        public void AddNewCategory(Category newCategory)
        {
            try
            {

              conn.InsertWithChildren(newCategory, recursive:true); //
                MessageStatus =
                    $"Registro ingresado. Product Id: {newCategory.Id}, Name: {newCategory.CategoryName}";
            }

            catch (Exception ex)
            {

                MessageStatus = $"Error al guardar registro. Error: {ex.Message}";
            }
        }

        public List<Category> GetCategories()
        {
           return  conn.Table<Category>().ToList();
        }

        public List<Category> GetCategoriesWithChildren()
        {
            return conn.GetAllWithChildren<Category>();
        }
    }
}
