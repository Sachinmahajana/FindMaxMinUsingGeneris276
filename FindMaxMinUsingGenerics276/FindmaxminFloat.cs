using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxMinUsingGenerics276
{
    internal class FindmaxminFloat
    {
        public static void FindMaxMinFloatFunction(float first,float second,float third)
        {
             if(first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is a greater number than {1} {2}", first, second, third);
            }
             else if(second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine("{1} is greater than {0} {2}",second,first,third);
            }
            else
            {
                Console.WriteLine("{2} is greater than {0} {1}", third, first, second);
            }
        }
    }
}
