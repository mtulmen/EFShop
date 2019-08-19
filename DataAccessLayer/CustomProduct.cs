using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomProduct
    {
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public decimal? Price { get; set; }
        public string CategoryName { get; set; }
    }
}
