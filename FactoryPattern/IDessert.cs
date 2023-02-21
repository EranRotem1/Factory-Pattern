using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface IDessert
    {
        public abstract void Eat();
        public string Flavor { get; set; }
    }
}
