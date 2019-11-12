using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clipart
{
    class Circle : Figure, IArea
    {

        public Circle(double width, double height) : base(width, height)
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
