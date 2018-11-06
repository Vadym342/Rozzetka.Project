using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Suppliers
    {
        public Suppliers()
        {
            addresses = new List<Addresses>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Addresses> addresses { get; set; }
    }
}
