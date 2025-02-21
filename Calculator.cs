using System.Collections.Generic;

namespace Delegate_and_Reflection
{
    public delegate int Calculate(int x, int y);
    internal class Calculator
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static void Result()
        {
            Calculate calc = Add;
            Console.WriteLine("Addition: " + calc(5, 3));

            calc = Subtract;
            Console.WriteLine("Subtraction: "+ calc(5, 3));
        }
    }
}
