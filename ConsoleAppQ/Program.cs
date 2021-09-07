using System;
using System.Collections.Generic;

namespace ConsoleAppQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape Square = new Shape { };
            Shape Rectangle = new Shape { };
            Shape Triangle = new Shape { };

            List<Shape> myShapes = new List<Shape>
            {
                Square,
                Rectangle,
                Triangle,
            };


            Console.WriteLine("Greetings User, Please select a Shape");
            var typeOfShape = new List<string>();
            typeOfShape.Add("A) Square");
            typeOfShape.Add("B) Rectangle");
            typeOfShape.Add("C) Triangle");
            typeOfShape.Add("L) List");

            foreach (var type in typeOfShape)
            {
                Console.WriteLine(type);
            }
            while (true)
            {
                Console.WriteLine("Type A, B, C or L");
                string chosenShape = Console.ReadLine();

                if (chosenShape.ToUpper() == "A")
                {
                    Console.WriteLine("Type Color");
                    Console.ReadLine();
                    Console.WriteLine("enter side");
                    int side1 = Convert.ToInt32(Console.ReadLine());
                    var sq = new Square(side1);
                    Console.WriteLine(value: $"Area is {sq.GetArea()}");
                }
                else if (chosenShape.ToUpper() == "B")
                {
                    Console.WriteLine("Type A Color");
                    Console.ReadLine();
                    Console.WriteLine("enter length side");
                    int side1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter width side");
                    int side2 = Convert.ToInt32(Console.ReadLine());
                    var rec = new Rectangle(side1, side2);
                    Console.WriteLine($"Area is {rec.GetArea()}");
                }
                else if (chosenShape.ToUpper() == "C")
                {
                    Console.WriteLine("Type A Color");
                    Console.ReadLine();
                    Console.WriteLine("enter first side");
                    int side1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter second side");
                    int side2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter third side");
                    int side3 = Convert.ToInt32(Console.ReadLine());
                    var tri = new Triangle(side1, side2, side3);
                    Console.WriteLine($"Area is {tri.GetArea()}");
                }
                else if (chosenShape.ToUpper() == "L")
                {
                    //var sh = new Shape();
                    Console.WriteLine($"Thank you");// not working
                    break;
                }

            }
        }   

    }
}



