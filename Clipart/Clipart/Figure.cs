using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clipart
{
    abstract class Figure
    {
        private double _width;
        private double _height;

        public static List<Figure> ListFigure = new List<Figure>();
        public Figure(double width,double height)
        {
            this._width = width;
            this._height = height;
        }




    }
}
