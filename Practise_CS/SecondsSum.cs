using System;

namespace Practise_CS
{
    public class SecondsSum
    {
        public static void SecSum(int total)
        {
            //Переводим общее время в минуты и секунды
            var ts = TimeSpan.FromSeconds(total);
            if (ts.Seconds < 10)
            {
                Console.WriteLine("{0}:0{1}", ts.Minutes, ts.Seconds);
            }
            else
            {
                Console.WriteLine("{0}:{1}",ts.Minutes,ts.Seconds);
            }
        }
    }
}