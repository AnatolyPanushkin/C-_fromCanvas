﻿using System;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace Practise_CS
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Суммирование секунд, " +
                              "2 - Информация о скорости");
            switch (Console.ReadLine())
            {
                //Задача: Суммирование секунд
                case "1":
                    int total = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        int time = Int32.Parse(Console.ReadLine());
                        total += time;
                    }
                    SecondsSum.SecSum(total);   
                    break;
                
                //задача: Информация о скорости
                case "2":
                    InformationAboutSpeed.Speed(double.Parse(Console.ReadLine()));  
                    break;
            }
            
           
            
            
        }
    }
}