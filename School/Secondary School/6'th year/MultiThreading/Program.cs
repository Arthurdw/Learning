using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread taskOne = new Thread(Program.taskBoys);
            Thread taskTwo = new Thread(Program.taskGirls);

            taskOne.Start();
            taskTwo.Start();
            Console.ReadLine();
        }

        public static void taskBoys()
        {
            string[] theBoys = new[] { "Jari", "Arthur", "Remco", "Lucas", "Tomma", "Loeka", "Boris", "Casper", "Gunar", "Ward", "Ruben", "Jean-Baptiste" };
            foreach (string boy in theBoys) Console.WriteLine(boy);
        }

        public static void taskGirls()
        {
            string[] theGirls = new[] { "Magot", "Hanna", "Fem", "Lilly", "Natacha" };
            foreach (string girl in theGirls) Console.WriteLine(girl);
        }

    }
}
