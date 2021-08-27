using System;
using System.Collections.Generic;
using AdvancedCs;

namespace AdvancedCs
{
    class Program
    {
        static void Main(string[] args)
        {
            AdvancedList<int> advancedList = new List<int>() { 1, 2, 3, 4, 5 }.ToAdvancedList();
        }
    }
}
