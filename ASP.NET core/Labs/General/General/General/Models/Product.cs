using System;
using System.Collections.Generic;

namespace General.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string DisplayName { get; set; }
        public double? Price { get; set; }
        public double? Sale { get; set; }
        public int? Idlevel { get; set; }
    }
}
