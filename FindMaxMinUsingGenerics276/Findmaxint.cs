using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxMinUsingGenerics276
{
    internal class Findmaxint
    {
        public static void FindMaxintFunction(int num1,int num2,int num3)
        {      
            // 50 20 30 (1,-1,0)
            if (num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) >= 0)
            {
                Console.WriteLine("{0} is greater number than {1} {2}", num1 ,num2,num3);
            }
            else if(num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) >= 0)
            {
                Console.WriteLine("{1} is a greater number", num2);
            }
            else
            {
                Console.WriteLine("{2} is a greater number");
            }

            
        }
    }
}
