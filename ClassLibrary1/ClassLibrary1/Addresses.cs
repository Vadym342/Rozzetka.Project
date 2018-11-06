using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public  class Addresses
    {
        public Addresses()
        {
            countries = new List<Countries>();
        }
        public int ID { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public List<Countries> countries { get; set; }
    }
}
