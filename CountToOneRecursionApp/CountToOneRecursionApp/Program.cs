using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountToOneRecursionApp
{
    class Program 
    {
        static void Main(string[] args) 
        {
            // Counting down to one example/
            Console.WriteLine("Please enter an integer. Using a math formula and simple recursion, we will reduce this number to 1!");
            int startingNumber = int.Parse(Console.ReadLine());
            int x = countToOne(startingNumber);

            Console.ReadLine();

            // Factorial example.
            Console.WriteLine("Now, let's look into this number's factorial!");
            long y = Factorial(startingNumber);

            Console.WriteLine("The factorial is: " + y);

            Console.ReadLine();

            // Greatest common divisor example.
            Console.WriteLine("Finally, let's explore this numbers greatest common divisor with another integer.");
            Console.WriteLine("Please enter another integer:");
            int secondNumber = int.Parse(Console.ReadLine());
            int z = greatestCommonDivisor(startingNumber, secondNumber);

            Console.WriteLine("The greatest common divisor of {0} and {1} is {2}.", startingNumber, secondNumber, z);

            Console.ReadLine();
        }

        public static int countToOne(int n)
        {
            Console.WriteLine("Number = " + n);

            // Base case. ALWAYS NEED A BASE CASE FOR RECURSION! Otherwise, infinite loop.
            if (n == 1) 
            {
                Console.WriteLine("Number = 1. Base case.");
                return 1;
            } 
            else 
            { 
                if (n % 2 == 0) 
                {
                    Console.WriteLine("Number is even. Divide by 2.");
                    return countToOne(n / 2);
                } 
                else 
                {
                    Console.WriteLine("Number is odd. Add 1.");
                    return countToOne(n + 1);
                } 
            }
        }

        public static long Factorial(int x) 
        {
            Console.WriteLine("Steps to go: " + x);

            // Base case. ALWAYS NEED A BASE CASE FOR RECURSION! Otherwise, infinite loop.
            if (x == 1) 
            {
                Console.WriteLine("Number = 1. Base case.");
                return 1;
            } 
            else 
            {
                Console.WriteLine("Calculating the factorial for " + x + " * factorial (" + (x - 1) + " - 1)");
                return x * Factorial(x - 1);
            }
        }

        public static int greatestCommonDivisor(int a, int b)
        {
            // Base case. ALWAYS NEED A BASE CASE FOR RECURSION! Otherwise, infinite loop.
            if (b == 0) 
            {
                Console.WriteLine("The greatest common divisor has been found!");
                return a;
            } 
            else 
            {
                Console.WriteLine("Not yet. {0} / {1} has a reminder of {2}.", a, b, (a % b));
                return greatestCommonDivisor(b, a % b);
            }
        }
    }
}
