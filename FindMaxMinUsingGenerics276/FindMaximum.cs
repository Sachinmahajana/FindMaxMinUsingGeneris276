
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumUsingGenerics
{
    internal class FindMaximum<T> where T : IComparable
    {
        public static void FindingMaximum(T input1, T input2, T input3) 
        {
            if (input1.CompareTo(input2) >= 0 && input1.CompareTo(input3) >= 0)
            {
                Console.WriteLine("Maximum is:" + input1);
            }
            else if (input2.CompareTo(input2) >= 0 && input2.CompareTo(input3) >= 0)
            {
                Console.WriteLine("Maximum is:" + input2);
            }
            else
            {
                Console.WriteLine("Maximum is:" + input3);
            }
        }

    }
}