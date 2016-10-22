using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static List<int> retval;

        static void Main(string[] args)
        {
            retval = new List<int>();


            int t = Convert.ToInt32(Console.ReadLine());
            string cache = "";


            List<long> maximums = new List<long>();
            for (int a0 = 0; a0 < t; a0++)
            {
                maximums.Add(Convert.ToInt64(Console.ReadLine()));
            }

            foreach(long max in maximums)
            {
                next(3, max);
                next(5, max);

                retval.Sort();
                Console.WriteLine(retval.Sum());
                retval.Clear();
            }

            Console.Write(cache);

        }

        static void next(int multiple, long max)
        {
            for(int i = multiple, x = multiple, multiplier = 1; (multiplier * x) < max; multiplier++, i = multiplier * x)
            {
                if (!retval.Contains(i))
                {
                    retval.Add(i);
                }
            }
        }


    }
}
