using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppQ
{
   public class Triangle : Shape
    {
        public int side1;
        public int side2;
        public int side3;

        public Triangle(int side1, int side2, int side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public Triangle(string color, int side1, int side2, int side3)
        {
            Name = "Triangle";
            Color = color;

        }
        public override int GetArea() => Convert.ToInt32(Math.Sqrt((side1 + side2 + side3 / 2) * (side1 * side2 * side3)));
    }
}
