using System;

namespace Practise_CS
{
    public class InformationAboutSpeed
    {
        public static void Speed(double speed)
        {
            if (speed<=10)
            {
                Console.WriteLine("Медленно");
            }
            else
            {
                Console.WriteLine("Быстро");
            }
        }
    }
}