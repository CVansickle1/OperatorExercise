using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorExercise
{
    internal class Methods
    {
        public static int Sum(params int[] addNumbers)
        {
            int total1 = 0;

            foreach (int y in addNumbers)
            {
                total1 += y;
            }
            return total1;

        }
        public static double Multiply(params int[] mulNumbers)

        {
            int total2 = 1;

            foreach (int y in mulNumbers)
            {
                total2 *= y;
            }
            return total2;
        }

        public static int Divide(int divNumber1, params int[] divNumber2)
        {

            foreach (int x in divNumber2)
            {
                divNumber1 /= x;
            }
            return divNumber1;
        }
        public static int Minus(params int[] minNumbers)
        {
            var total4 = minNumbers[0];

            for (int i = 1; i < minNumbers.Length; i++)
            {
                total4 -= minNumbers[i];
            }
            return total4;
        }

        public static double AreaOfCircle(double radius)
        {
            double area;

            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
