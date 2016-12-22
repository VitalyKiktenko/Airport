using System;
using System.Collections.Generic;

namespace Airports
{
    class Prices
    {
        public static void Show()
        {
            Console.WriteLine("Price: ");
            Console.WriteLine();
            foreach (var p in prie)
            {
                Console.WriteLine("Price per ticket {0} of class = {1} $ ", p.Key, p.Value);
            }
        }

        public static Dictionary<Class, int> prie = new Dictionary<Class, int>();

        public static void AddPriece()
        {
            Random r = new Random();
            prie.Add(Class.A, r.Next(2000, 3000));
            prie.Add(Class.B, r.Next(1500, 2000));
            prie.Add(Class.C, r.Next(1000, 1500));
            prie.Add(Class.D, r.Next(500, 1000));
        }
    }
}