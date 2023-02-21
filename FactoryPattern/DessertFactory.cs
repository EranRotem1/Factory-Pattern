using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class DessertFactory
    {
        public static IDessert GetDessert(string flavor)
        {
            Console.WriteLine("Ice Cream or Froyo?");
            string dessert = Console.ReadLine();
            switch (dessert.ToLower())
            {
                case "ice cream":
                    Console.WriteLine($"{flavor} ice cream!!");
                    return new IceCream(flavor);
                case "froyo":
                    Console.WriteLine($"{flavor} frozen yogurt!!");
                    return new FroYo(flavor);
                default:
                    Console.WriteLine("That wasn't a valid input im afraid, you're getting Ice Cream");
                    return new IceCream(flavor);
            }
        }
    }
}
