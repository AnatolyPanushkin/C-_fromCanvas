using System;

namespace Practise_CS
{
    public class NumbersEnd7
    {
        public static void Numbers()
        {
            for (int i = 0; i < 1001; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}