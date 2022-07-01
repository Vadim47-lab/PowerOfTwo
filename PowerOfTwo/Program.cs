using System;

namespace PowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Программа степень двойки:");

            Random random = new Random();
            int baseDegree = 2;
            int initialNumber = 1;
            int finitNumber = 100;
            int result = 0;
            int minDegree;

            int number = random.Next(initialNumber, finitNumber);

            for (minDegree = 0; result < number; minDegree++)
            {
                result = (int)Math.Pow(baseDegree, minDegree);
            }

            Console.WriteLine("\n Вывод числа N = " + number + ", степень minDegree = " + minDegree + " и само число 2 в найденной степени result = " + result + ".");
        }
    }
}