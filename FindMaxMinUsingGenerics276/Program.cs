namespace FindMaxMinUsingGenerics276
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Findmaxmin Generics program");
            Console.WriteLine("Select the program given below");
            Console.WriteLine("\n1:Findmaxint\n2:FindFloatmaxmin\n3:FindMaxminstring");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Findmaxint.FindMaxintFunction(50, 20, 30);
                    break;
                case 2:
                    FindmaxminFloat.FindMaxMinFloatFunction(50.3f,40.2f,30.4f);
                    break;
                case 3:
                    FindMaxminstring.FindMaxstringFunction("Apple","Peach","banana");
                    break;
                default:
                    Console.WriteLine("Please select the program given below");
                    break;
            }  
        }
    }
}