using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Producers
    {
        public Producers()
        {
            addresses = new List<Addresses>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Addresses> addresses { get; set; }
    }
}
