using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class FizzBuzz
    {
        private int _upperLimit;
        public FizzBuzz(int upperLimit)
        {
            _upperLimit = upperLimit;
        }
        public void PrintNumbers()
        {
            for (int i = 1; i <= _upperLimit; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

        }

    }
}