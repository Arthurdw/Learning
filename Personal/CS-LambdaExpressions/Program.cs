using System;
using System.Linq;

namespace LambdaExpressions
{
    class Program
    {
        public delegate string ParamsFunc(params string[] args);

        static void Main(string[] args)
        {
            static int IntResultFunc(int x) => x * x;
            Console.WriteLine(IntResultFunc(5));

            Func<int, int> IntResultFuncObj = x => x * x;
            Console.WriteLine(IntResultFuncObj(5));

            static string AddStrFunc(params string[] args) => string.Join("", args);
            Console.WriteLine(AddStrFunc("Hello", ", ", "World"));

            ParamsFunc AddStrFuncObj = x => string.Join("", x);
            Console.WriteLine(AddStrFuncObj("Hello", ", ", "World"));


            int[] numbs = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine($"There are {numbs.Count(num => num % 2 == 0)} even numbers in \"{string.Join(", ", numbs)}\".");
            Console.WriteLine($"The even numbers are \"{string.Join(", ", numbs.Where(num => num % 2 == 0))}\".");
        }
    }
}
