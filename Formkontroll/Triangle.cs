using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formkontroll
{
    internal class Triangle : Shape
    {
        private double _base;
        private double _height;

        public Triangle(string name, string color, double @base, double height) : base(name, color)
        {
            _base = @base;
            _height = height;
        }
        public override double BeregnAreal()
        {
           Areal = _base / 2 * _height;
            return Areal;
        }

       
    }
}
