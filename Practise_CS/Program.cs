using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Practise_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 0; i < 3; i++)
            {
                int time = Int32.Parse(Console.ReadLine());
                total += time;
            }
            SecondsSum.SecSum(total);
        }
    }
}