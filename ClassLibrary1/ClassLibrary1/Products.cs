using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Products
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set;}
        public int QuantityinStorage  { get; set; }
        public List<Categories> categories { get; set; }

    }
}
