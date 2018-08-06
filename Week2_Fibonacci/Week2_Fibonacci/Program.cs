using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week2_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            uint num1 = 0;
            uint num2 = 1;
            uint num3 = 0;
            var fibprime = new List<uint>();
            var fib = new List<uint>();

            var fact = new List<uint>();


            Console.WriteLine("next");
            var exit = false;
            while (!exit)
            {
                try
                {
                    num3 = num1 + num2;
                    if (IsPrime((int) num3))
                    {
                        if (fibprime.Count() <= 8) Console.WriteLine("--" + num3);
                        fibprime.Add(num3);
                    }
                    else
                    {
                        if (fibprime.Count() <= 8) Console.WriteLine(num3);

                    }
                    fib.Add(num3);

                    num1 = num2;
                    num2 = num3;
                    fact.Add(factorial(fib.Count()-1));
                    two(fib,fact);
                }
                catch
                {
                    exit = true;
                }
                
            }

            Console.WriteLine();


            Console.WriteLine();




            Console.ReadKey(true);

        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        static uint factorial(int num)
        {
            if (num == 0) return 0;
            uint num2 = 1;
            for (uint i = 1; i < num+1; i++)
            {
                num2 *= i;
            }
            return num2;
        }

        static void two(List<uint> fib, List<uint> fact)
        {


            foreach (var item1 in fib)
            {
                foreach (var item2 in fact)
                {
                    if ((item1 == item2 && item2 > 2)) Console.WriteLine(">>" + item2);
                }
            }
        }

    }
}
