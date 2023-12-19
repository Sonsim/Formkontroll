using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formkontroll
{
    internal class Circle : Shape
    {
        private int _radius;
 

        public Circle(int radius, string Name, string Color) : base(Name, Color)
        {
            _radius = radius;
           
        }
        public override double BeregnAreal()
        {
            Areal = _radius * _radius * Math.PI;
            return Areal;
        }

      
    }
}
