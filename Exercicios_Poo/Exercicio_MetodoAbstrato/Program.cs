using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio_MetodoAbstrato.Entites;
using Exercicio_MetodoAbstrato.Enums;

namespace Exercicio_MetodoAbstrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n;i++)
            {
                Console.WriteLine($"Shapes #{i} data : ");

                Console.Write("Rectangle or Circle (r/c): ");
                string c = Console.ReadLine().ToLower();

                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (c == "r")
                {
                    Console.Write("Width: ");
                    double w = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    double h = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    shapes.Add(new Rectangle(color,w,h));

                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    shapes.Add(new Circle(color,radius));
                }

            }


            Console.WriteLine();
            
            Console.WriteLine("Shapes Areas: ");

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
