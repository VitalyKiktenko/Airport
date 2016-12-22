using System;
using System.Collections.Generic;

namespace Airports
{
    class CreateFlight : IMenuActioncs
    {
        public void Show(ArrivalsPlans arr, DeparturesPlans dep, List<LineInfo> allFlights)
        {
            int num;
            bool choice;
            Console.Clear();
            Console.WriteLine("Which flight do you want to create \n #1 Arrivals\n #2 Depatures ");
            Console.WriteLine("Enter a figure.");
            choice = int.TryParse(Console.ReadLine(), out num);
            if (num == 1)
            {
                arr.Create(allFlights);

            }
            else if (num == 2)
            {
                dep.Create(allFlights);
            }
            else Console.WriteLine("Incorrect input");
            if (num == 1)
            {
                Console.WriteLine("A new flight Arrivals");

            }
            else
                Console.WriteLine("A new flight Depatures");
        }
    }
}