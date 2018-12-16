using System;

namespace Task4
{
    public class Program4
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle();

            Console.Write("Please enter X coordinate of vertex A: ");
            double xA = Double.Parse(Console.ReadLine());

            Console.Write("Please enter Y coordinate of vertex A: ");
            double yA = Double.Parse(Console.ReadLine());

            Console.Write("Please enter X coordinate of vertex B: ");
            double xB = Double.Parse(Console.ReadLine());

            Console.Write("Please enter Y coordinate of vertex B: ");
            double yB = Double.Parse(Console.ReadLine());

            Console.Write("Please enter X coordinate of vertex C: ");
            double xC = Double.Parse(Console.ReadLine());

            Console.Write("Please enter Y coordinate of vertex C: ");
            double yC = Double.Parse(Console.ReadLine());

            double a = t.CalculateSide(xB, xC, yB, yC);
            double b = t.CalculateSide(xC, xA, yC, yA);
            double c = t.CalculateSide(xA, xB, yA, yB);

            Console.WriteLine($"The area of the triangle is: {t.CalculateArea(a, b, c)}");
        }
    }
}
