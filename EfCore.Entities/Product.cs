using System;
using System.Collections.Generic;
using System.Text;

namespace EfCore.Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public Category Category { get; set; }

    }
}
