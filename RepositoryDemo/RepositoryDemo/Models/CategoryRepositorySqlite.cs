using RepositoryDemo.Services;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

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
        }

        // TODO: Este método debe guardar objetos con hijos
        public void AddNewCategory(Category newCategory)
        {
            try
            {

                conn.Insert(newCategory); //
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
    }
}
