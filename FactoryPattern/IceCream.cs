using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class IceCream : IDessert
    {
        public string Flavor { get; set; }
        public IceCream(string flavor)
        {
            Flavor = flavor;
        }

        public void Eat()
        {
            Console.WriteLine("Ouch! Brain frezze!");
        }
    }
}
