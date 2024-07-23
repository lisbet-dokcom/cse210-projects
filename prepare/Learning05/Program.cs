using System;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square squ = new Square("Red", 7);
        shapes.Add(squ);
        Rectangle rec = new Rectangle("Blue", 7, 9);
        shapes.Add(rec);
        Circle cir = new Circle("Pink", 8);
        shapes.Add(cir);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"This {color} shape has an area of {area}.");
        }

    }
}