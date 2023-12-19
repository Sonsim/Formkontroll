using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formkontroll
{
    abstract class Shape
    {
        public string Name { get; }
        public string Color { get; }
        public double Areal { get; set; }

        public Shape(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public abstract double BeregnAreal();
    }
}
