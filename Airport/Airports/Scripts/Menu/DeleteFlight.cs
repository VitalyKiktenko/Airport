using System;
using System.Collections.Generic;

namespace Airports
{
    class DeleteFlight : IMenuActioncs
    {
        public void Show(ArrivalsPlans arr, DeparturesPlans dep, List<LineInfo> allFlights)
        {
            int num;
            bool choice;
            Console.Clear();
            Console.WriteLine("Which flight do you want to delete? \n #1 Arrivals\n #2 Depatures ");
            Console.WriteLine("Enter a figure.");
            choice = int.TryParse(Console.ReadLine(), out num);
            if (num == 1)
            {
                arr.Delete(allFlights);
            }
            else if (num == 2)
            {
                dep.Delete(allFlights);
            }
            else Console.WriteLine("Incorrect input");
        }
    }
}