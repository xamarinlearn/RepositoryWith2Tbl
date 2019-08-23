using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace RepositoryDemo.Models
{
    [Table("Products")]
  public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100),Unique]
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public int UnitsInStock { get; set; }
    }
}
