using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppQ
{
    public class Rectangle : Shape
    {
        public int side1;
        public int side2;

        public Rectangle(int side1, int side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public Rectangle(string color, int side, int side0)
        {
            Name = "Rectangle";
            Color = color;
            side1 = side;
            side2 = side0;
        }

        public override int GetArea() => side1 * side2;


    }
}
