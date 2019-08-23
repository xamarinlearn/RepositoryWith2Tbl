﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryDemo.Models
{
   public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public List<Product> Products { get; set; }

    }
}
