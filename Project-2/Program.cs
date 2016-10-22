/* Created By: Kevin B. Harris
 * Date: October 20, 2016 
 * 
 * Description: Project Euler is a set of programming challenges 
 * juxtupposed with mathematics. This project focuses on
 * the second Project Euler challenge: Even Fibonacci numbers.
 */  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Program
    {
        static void Main(String[] args)
        {     
            if (args.Count() < 2)
            {
                int sets = Convert.ToInt32(Console.ReadLine());
                List<string> to_array = new List<string>();


                do
                {
                    to_array.Add(Console.ReadLine());
                    sets--;

                } while (sets > 0);
                to_array.Insert(0, to_array.Count().ToString());
                args = to_array.ToArray();
            }

            for (int i = 0; i < args.Count(); i++)
            {
                if (i > 0)
                {
                    long[] continuum = Fibonacci(long.Parse(args[i]));
                    long sum = 0;
                    for (int x = 1; x < continuum.Count(); x += 3)
                    {
                        sum += continuum[x];
                    }
                    Console.Write(sum);
                    Console.Write("\n");
                }
            }

            Console.ReadKey();
        }

        static long[] Fibonacci(long max)
        {
            List<long> continuum = new List<long>();
            continuum.AddRange(new long[] { 1, 2 });

            do
            {
                continuum.Add(continuum[continuum.Count - 2] + continuum[continuum.Count - 1]);
            } while (continuum[continuum.Count - 2] + continuum[continuum.Count - 1] < max);

            return continuum.ToArray();
        }
    }
}
