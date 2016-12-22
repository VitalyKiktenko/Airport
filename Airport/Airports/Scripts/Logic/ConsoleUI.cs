using System;
using System.Collections.Generic;

namespace Airports
{
    class ConsoleUI
    {
        bool show = true;
        public void ShowConsole()
        {
            ArrivalsPlans arr = new ArrivalsPlans();
            DeparturesPlans dep = new DeparturesPlans();
            Passenger.GetPassenger(Passenger.AllPassengers);
            Prices.AddPriece();
            List<LineInfo> allFlights = AddFligts();
            do
            {
                show = ShowMenu(arr, dep, allFlights);
            }
            while (show);
        }

        private bool ShowMenu(ArrivalsPlans arr, DeparturesPlans dep, List<LineInfo> allFlights)
        {
            bool chek = true;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"      Hello, select an item from the list, to do this enter the related figure.");
            Console.WriteLine(@"
1. The information on all flights
2. The information regarding arrivals.
3. The information regarding departures.
4. The information about passengers.
5. The price list.
6. To charter a new flight.
7. To edit a flight.
8. To cancel the flight.
9. Search
0. Click 0 for exit");

            int menu = 0;
            bool tryInput = int.TryParse(Console.ReadLine(), out menu);
            Dictionary<int, IMenuActioncs> actions = new Dictionary<int, IMenuActioncs>()
            {
                {   1, new ShowAllFLightsMenu()    },
                {   2, new ShowArriveFlights()     },
                {   3, new ShowDepartFLightsMenu() },
                {   4, new ShowPassengers()        },
                {   5, new ShowPriece()            },
                {   6, new CreateFlight()          },
                {   7, new EditFlight()            },
                {   8, new DeleteFlight()          },
                {   9, new SearchFlights()         }
            };
            if (menu <= 9 && menu != 0)
            {
                actions[menu].Show(arr, dep, allFlights);
            }
            else if (menu == 0)
            {
                chek = false;
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
            Console.ReadLine();
            return chek;
        }

        private static List<LineInfo> AddFligts()
        {
            List<LineInfo> ob = new List<LineInfo>();
            ob.Add(new ArrivalsPlans(
                (DateTime.Today - new TimeSpan(3, 10, 0)), null, Number.FF148, Status.Boarding, Terminal.first, Class.A, Passenger.AllPassengers));
            ob.Add(new ArrivalsPlans(
                (DateTime.Today - new TimeSpan(8, 30, 0)), null, Number.LN45P, Status.Boarding, Terminal.first, Class.B, Passenger.AllPassengers));
            ob.Add(new DeparturesPlans(
                 (DateTime.Today + new TimeSpan(5, 20, 0)), null, Number.AC12G, Status.Boarding, Terminal.first, Class.D, Passenger.AllPassengers));
            ob.Add(new DeparturesPlans(
                (DateTime.Today + new TimeSpan(2, 30, 0)), null, Number.PG313, Status.Boarding, Terminal.first, Class.C, Passenger.AllPassengers));
            return ob;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            ConsoleUI ob = new ConsoleUI();
            ob.ShowConsole();
            Console.ReadLine();
        }
    }
}