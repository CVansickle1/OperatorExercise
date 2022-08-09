using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            int awnser = Methods.Sum(20, 12);
            
            Console.WriteLine($" 20 + 12 = {awnser}" );
            
            double awnser2 = Methods.Multiply(50,80);
            
            Console.WriteLine($"50 x 80 = {awnser2}");
            
            int awnser3 = Methods.Minus(89, 53);

            Console.WriteLine($"89 - 53 = {awnser3}");
            
            int a = 17;
            
            int b = 4;

            double quotient = Methods.Divide(a, b);

            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} with a remainder of {remainder}");

            Console.WriteLine("What is the Radius of your circle?");

            var radius = double.Parse(Console.ReadLine());
            double area = Methods.AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with a radius of {radius} is {area}");



        }
    }
}
