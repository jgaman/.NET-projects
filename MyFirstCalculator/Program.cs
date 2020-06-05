using System;

namespace MyFirstCalculator
{
    class Program
    {
        private const double _MIN_VALUE_Double = -1000;
        private const double _MAX_VALUE_Double = 1000;
        static void Main(string[] args)
        {
            double firstDouble = 0;
            double secondDouble = 0;
            double totalDouble = 0;
            bool OKBool = true;
            Console.WriteLine("Welcome to My Calculator.");


            Console.Write("\nEnter first number: ");
            firstDouble = double.Parse(Console.ReadLine());

            Console.Write("\nEnter second number: ");
            secondDouble = double.Parse(Console.ReadLine());

            totalDouble = firstDouble + secondDouble;

            Console.WriteLine("\n{0} + {1} = {2}\n",
                firstDouble, secondDouble, totalDouble);

            Console.Write("Press ENTER key to end program.");
            Console.ReadLine();

        }
    }
}
