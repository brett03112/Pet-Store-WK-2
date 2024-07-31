﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    internal class Product
    {
        protected static readonly List<Product> _products;

        public decimal Price { get; set; }

        public string? Name { get; set; }

        public int Quantity { get; set; }

        public string? Description { get; set; }
    }
}
