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
            int[][] sequences = iterate(new int[] { 3, 5 }, 1000);

            List<int> order = new List<int>(1000);
            foreach(int[] sequence in sequences)
            {
                foreach (int multiple in sequence)
                {
                    order.Add(multiple);

                }
            }

            order = order.Distinct().ToList();
            order.Sort();

            Console.Write(string.Join(",", order.ToArray()));
            Console.ReadKey();
        }

        static void next(int multiple, ref int i)
        {
            i = multiple * ((i / multiple) + 1);
        }

        static int[] iterate(int multiple, int max)
        {
            List<int> retval = new List<int>();
            for (int i = 0; i < max; next(multiple, ref i))
            {
                if (i > 0)
                {
                    retval.Add(i);
                }
            }

            return retval.ToArray();
        }

        static int[][] iterate(int[] multiples, int max)
        {
            List<int[]> arrays = new List<int[]>();

            foreach (int multiple in multiples)
            {
                arrays.Add(iterate(multiple, max));
            }

            return arrays.ToArray() ;
        }
    }
}
