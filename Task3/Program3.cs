using System;

namespace Task3
{
    public class Program3
    {
        public static void Main(string[] args)
        {
            Circle c = new Circle();
            
            Console.Write("Please enter the radius of the circle: ");
            double r = Double.Parse(Console.ReadLine());
            if (r > 0)
            {
                Console.WriteLine($"Circumference is: {c.CalculateCircumference(r)}");
                Console.WriteLine($"Area is: {c.CalculateArea(r)}");
            }
            else
            {
                Console.WriteLine("Radius must be number greater than zero!");
            }
        }
    }
}
