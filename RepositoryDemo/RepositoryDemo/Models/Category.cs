using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
using SQLiteNetExtensions.Extensions;

namespace RepositoryDemo.Models
{
   public class Category
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }

        [MaxLength(100),Unique]
        public string CategoryName { get; set; }
        public string Description { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.CascadeInsert)]
        public List<Product> Products { get; set; }

    }
}
