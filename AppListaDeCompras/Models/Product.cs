﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListaDeCompras.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        //TODO - trocar para enum
        public string QuantityUnitMeansure { get; set; }
        public decimal Price { get; set; }
    }
}
