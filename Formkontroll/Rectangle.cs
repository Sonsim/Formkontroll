using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formkontroll
{
    internal class Rectangle : Shape
    {
        private double _length;
        private double _width;

        public Rectangle(double Length, double Width,string name, string color) : base(name, color)
        {
            _length = Length;
            _width = Width;
        }

        public override double BeregnAreal()
        {
            Areal = _length * _width;

            return Areal;
        }


       
    }
}
