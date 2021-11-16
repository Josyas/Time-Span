﻿using System;

namespace Time_Span {
    class Program {
        static void Main(string[] args) {

            TimeSpan t1 = new TimeSpan(0, 1 ,30);

            Console.WriteLine(t1);
            Console.WriteLine("Ticks " + t1.Ticks);

            Console.WriteLine("===================================");

            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(900000000L);

            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.WriteLine("===================================");

            TimeSpan t4 = new TimeSpan(2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);

                  
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);

            Console.WriteLine("===================================");

            TimeSpan t7 = TimeSpan.FromDays(1.5);
            TimeSpan t8 = TimeSpan.FromHours(1.5);
            TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t11 = TimeSpan.FromSeconds(1.5);
            TimeSpan t12 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine("From Days: " + t7);
            Console.WriteLine("From Hours: " + t8);
            Console.WriteLine("From Minutes: " + t9);
            Console.WriteLine("Form Milli Secunds: " + t10);
            Console.WriteLine("From Seconds: " + t11);
            Console.WriteLine("From Ticks: " + t12);
        }
    }
}
