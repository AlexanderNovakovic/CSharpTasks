using System;

namespace Task2
{
    public class Program2
    {
        public static void Main(string[] args)
        {
            Number num = new Number();
            Console.Write("Please enter first number: ");
            num.FirstNumber = int.Parse(Console.ReadLine());

            Console.Write("Please enter second number: ");
            num.SecondNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"The sum of two entered numbers is: {num.Sum()}");
        }
    }
}
