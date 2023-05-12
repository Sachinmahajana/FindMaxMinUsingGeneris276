using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxMinUsingGenerics276
{
    internal class FindMaxvalue<T> where T : IComparable
    {
        public T value1, value2, value3, value4, value5;
        public FindMaxvalue(T value1, T value2, T value3, T value4, T value5)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
            this.value4 = value4;
            this.value5 = value5;
        }
        public static void Testmaximum(T value1, T value2, T value3, T value4, T value5)
        {
            if (value1.CompareTo(value2) >= 0 && value1.CompareTo(value3) >= 0 && value3.CompareTo(value4) >= 0 && value4.CompareTo(value5) >= 0)
            {
                Console.WriteLine("This value is Maximum:" + value1);
            }
            else if (value2.CompareTo(value1) >= 0 && value2.CompareTo(value3) >= 0 && value2.CompareTo(value4) >= 0 && value2.CompareTo(value5) >= 0)
            {
                Console.WriteLine("This value is maximum:" + value2);
            }
            else if (value3.CompareTo(value1) >= 0 && value3.CompareTo(value2) >= 0 && value3.CompareTo(value4) >= 0 && value3.CompareTo(value5) >= 0)
            {
                Console.WriteLine("This value is maximum:" + value3);
            }
            else if(value4.CompareTo(value1) >= 0 && value4.CompareTo(value2) >= 0 && value4.CompareTo(value3) >=0 && value4.CompareTo(value5) >= 0)
            {
                Console.WriteLine("This value is maximum:" + value4);
            }
            else
            {
                Console.WriteLine("This value is maximum:" + value5);
              
            }

        }
    }

}