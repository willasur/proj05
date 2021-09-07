using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppQ
{
    public class Square : Shape
    {
        public int side1;

        public Square(int side1)
        {
            this.side1 = side1;
        }

        public Square(string color, int side)
        {
            Name = "Square";
            Color = color;
            side1 = side;
        }

        public override int GetArea() => side1 * side1;

    }
}
