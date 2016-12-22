using System;
using System.Collections.Generic;

namespace Airports
{
    class EditFlight : IMenuActioncs
    {
        public void Show(ArrivalsPlans arr, DeparturesPlans dep, List<LineInfo> allFlights)
        {
            int num;
            bool choice;
            Console.Clear();
            Console.WriteLine("Which flight do you want to override? \n #1 Arrivals\n #2 Depatures ");
            Console.WriteLine("Enter a figure.");
            choice = int.TryParse(Console.ReadLine(), out num);
            if (num == 1)
            {
                arr.Edit(allFlights);
            }
            else if (num == 2)
            {
                dep.Edit(allFlights);
            }
            else Console.WriteLine("Incorrect input");
        }
    }
}