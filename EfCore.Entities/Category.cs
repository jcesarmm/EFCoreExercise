﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EfCore.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
