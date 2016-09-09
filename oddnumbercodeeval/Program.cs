using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddnumbercodeeval
{
    class Program
    {
        static void Main(string[] args)
        {
            //print out odd numbers from 1 thhrough 99 inclusive
            //start at 1, make condition lt or = 99, add 2 after each loop
            int counter;
            for (counter = 1; counter <= 99; counter += 2)
            {
                System.Console.WriteLine(counter);

            }
        }
    }
}
