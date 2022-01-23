using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            while (true)
            {
                var info = fizzBuzz.Play();
                if (info != "T")
                    Console.WriteLine($"{info}\n");
                else
                    break;
            }
        }
    }
}
