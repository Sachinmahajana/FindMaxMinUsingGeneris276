using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxMinUsingGenerics276
{
    internal class FindMaxvalue<T> where T : IComparable
    {
        public T value1, value2, value3;
        public FindMaxvalue(T value1, T value2, T value3)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
        }
        public static void Testmaximum(T value1, T value2, T value3)
        {
            if(value1.CompareTo(value2) >= 0 && value1.CompareTo(value3) >= 0)
            {
                Console.WriteLine("This value is Maximum:" + value1);
            }
            else if(value2.CompareTo(value1) >= 0 && value2.CompareTo(value3) >= 0)
            {
                Console.WriteLine("This value is maximum:" + value2);
            }
            else
            {
                Console.WriteLine("This value is maximum:" + value3);
            }
        }
    }
}
