using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerProductWebApp.Models
{
    public class Product
    {
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public int ProductPrice { get; set; }
        public Boolean ProductStatus { get; set; }
    }
}
