using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clipart
{
    class Triangle : Figure, IArea
    {

        public Triangle(double width, double height) : base(width, height)
        {

        }
        public double Area()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"";
        }
    }
}
