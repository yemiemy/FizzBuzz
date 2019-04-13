using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets read 1-100. \n At every multiple of 3, 5 and 15, FIZZ, BUZZ and FIZZBUZZ is displayed " +
                "respectively.");

            for (int i = 1; i <=100; i++ )
            {

                if (i % 15 != 0 && i % 3 != 0 && i % 5 != 0)
                {
                    Console.WriteLine(i );
                    

                }
                else if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz ");
                }
                


            }
            Console.ReadLine();
        }
    }
}
