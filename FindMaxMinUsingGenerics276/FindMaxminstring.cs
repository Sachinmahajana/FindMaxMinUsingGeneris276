using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxMinUsingGenerics276
{
    internal class FindMaxminstring
    {
        public static void FindMaxstringFunction(string name1,string name2,string name3) 
        {
            if(name1.CompareTo(name2) >= 0 && name1.CompareTo(name3) >= 0)
            {
                Console.WriteLine("Maximum name is: "+ name1);
            }
            else if(name2.CompareTo(name1) >= 0 && name2.CompareTo(name3) >= 0)
            {
                Console.WriteLine("Maximum name is: "+ name2);
            }
            else
            {
                Console.WriteLine("Maximum name is: "+ name3);
            }
        }
    }
}
