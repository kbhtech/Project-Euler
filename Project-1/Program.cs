using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> to_scan = new List<int>();
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                to_scan.Add(n);
            }

            foreach (int n in to_scan)
            {
                Console.WriteLine(scan(n));
            }

            Console.ReadKey();
        }


        static int scan(int max, int min = 0)
        {
            int retval = 0;

            for(int i = next(min); i < max; next(ref i))
            {
                retval += i;
            }

            return retval;
        }

        static void next(ref int pointer)
        {
            decimal value = System.Convert.ToDecimal(pointer);
            int next = 0;

            if (value / 5 - Math.Floor(value / 5) == 0)
            {
                next = 5;
            }

            if (value / 5 - Math.Floor(value / 5) >= System.Convert.ToDecimal(.20) && value / 5 - Math.Floor(value / 5) < System.Convert.ToDecimal(.40))
            {
               next = 4;
            }

            if (value / 5 - Math.Floor(value / 5) >= System.Convert.ToDecimal(.40) && value / 5 - Math.Floor(value / 5) < System.Convert.ToDecimal(.60))
            {
               next = 3;
            }
            if (value / 3 - Math.Floor(value / 3) == 0)
            {
               next = 3;
            }


            if (value / 5 - Math.Floor(value / 5) >= System.Convert.ToDecimal(.60) && value / 5 - Math.Floor(value / 5) < System.Convert.ToDecimal(.80))
            {
               next = 2;
            }
            if (value / 3 - Math.Floor(value / 3) >= System.Convert.ToDecimal(.33333) && value / 3 - Math.Floor(value / 3) < System.Convert.ToDecimal(.66666))
            {
                next = 2;
            }
            if (value / 5 - Math.Floor(value / 5) >= System.Convert.ToDecimal(.80))
            {
                next = 1;
            }
            if (value / 3 - Math.Floor(value / 3) >= System.Convert.ToDecimal(.66666))
            {
                next = 1;
            }


            pointer += next;
        }

        static int next(int pointer)
        {
            next(ref pointer);
            return pointer;
        }
    }
}
