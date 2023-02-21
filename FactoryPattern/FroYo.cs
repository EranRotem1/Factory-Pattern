using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class FroYo : IDessert
    {
        public void Eat()
        {
            Console.WriteLine("Mmmmmm yummy");
        }

        public string Flavor { get; set; }
        public FroYo(string flavor) 
        {
            Flavor = flavor;
        }
    }
}
