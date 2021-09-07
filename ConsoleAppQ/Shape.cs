using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppQ
{
    public class Shape
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Area { get; set; }


        public override string ToString()//not sure
        {
            return this.Name;
        }

        public string shapeColor()
        {
            return this.Color;
        }

        public virtual int GetArea()
        {
            return this.Area;
        }
    }
}
