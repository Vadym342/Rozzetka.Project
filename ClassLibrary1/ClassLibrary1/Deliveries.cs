using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
public  class Deliveries
    {
        public int ID { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set;}
        public DateTime DateTime { get; set; }

       public List<Products> products { get; set; }
       public List<Suppliers> suppliers { get; set; }


    }
}
