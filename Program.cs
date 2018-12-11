using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 11;
            int j = 44;

            if (i <= 10)
            {
                if (i <= 44)
                {
                    Console.WriteLine("i value is less than 44:{0}", i);

                }
                else
                {
                    Console.WriteLine("i value is greater than 44:{0}", i);
                }

            }
            else
            {
                if (j<= 11)
                {
                    Console.WriteLine("j value is greater than i  that is j:{0}", j);
                }

                else
                {
                    Console.WriteLine(" j value is less than j and value is j:{0}", j);
                }
            }

        }
    }
}
