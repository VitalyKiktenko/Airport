using System;
using System.Collections.Generic;

namespace Airports
{
    class DeparturesPlans : LineInfo
    {
        public DeparturesPlans() { }
        public DeparturesPlans(DateTime time, string city, Number number, Status status, Terminal terminal, Class cLass, List<Passenger> passengers)
        {
            this.Class = cLass;
            this.Price = Prices.prie[cLass];
            this.Time = time;
            if (city == null)
            {
                Cities c = new Cities();
                this.City = c.TakeCity();
            }
            else
            {
                this.City = city;
            }
            this.Number = number;
            this.Status = status;
            this.Terminal = terminal;
            this.Info = Info.Depart;
            foreach (var pas in passengers)
            {
                int index = 0;
                if (pas.FlightNumber == this.Number)
                {
                    this.passengers.Add(pas);
                    index++;
                }
            }
        }

        public override void Show(List<LineInfo> listinfo)
        {
            int index = 1;
            foreach (var i in listinfo)
            {
                if (i.Info == Info.Depart)
                {
                    Console.WriteLine("{0,25}  #{1}", " Depart ", index);
                    Console.WriteLine(i.ToString());
                    index++;
                }
            }
        }

        public override void Create(List<LineInfo> info)
        {
            bool check;
            Random r = new Random();
            DateTime inputTime = new DateTime(2016, r.Next(7, 12), r.Next(1, 29), r.Next(0, 24), r.Next(0, 60), r.Next(0, 60));
            string inputCity;
            Number inputNumber;
            Status inputStatus;
            Terminal inputTerminal;
            Class inputcLass;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Charter a flight");
            Console.ResetColor();
            Console.WriteLine("To what city is the flight?");
            string city = (Console.ReadLine());
            if (string.Empty == city)
            {
                Console.WriteLine("You didn't set any data.");
                return;
            }
            else { inputCity = city; }
            Console.WriteLine("Of which airlines is the flight? 1. {0} 2. {1} 3. {2} 4. {3} ", Number.FF148, Number.AC12G, Number.LN45P, Number.PG313);
            check = Enum.TryParse(Console.ReadLine(), out inputNumber);
            if (!check)
            {
                Console.WriteLine("This flight doesn't exist.");
            }
            Console.WriteLine("Of which status is the flight? 1) {0} 2) {1} 3) {2} 4) {3} 5) {4} 6) {5} 7) {6} 8) {7}", Status.Boarding, Status.Canceled, Status.Checkin, Status.Departed, Status.Expected
                , Status.Landed, Status.OnTime, Status.Unknown);
            check = Enum.TryParse(Console.ReadLine(), out inputStatus);
            if (!check)
            {
                Console.WriteLine("This status doesn't exist.");
            }
            Console.WriteLine("Of which terminal is the flight? 1) {0} 2) {1} 3) {2} 4) {3} 5) {4} 6) {5} ", Terminal.first, Terminal.second, Terminal.third, Terminal.fourth, Terminal.fifth, Terminal.sixth);
            check = Enum.TryParse(Console.ReadLine(), out inputTerminal);
            if (!check)
            {
                Console.WriteLine("This terminal doesn't exist.");
            }
            Console.WriteLine("Of which class is the flight? 1) {0} 2) {1} 3) {2} 4) {3}", Class.A, Class.B, Class.C, Class.D);
            check = Enum.TryParse(Console.ReadLine(), out inputcLass);
            if (!check)
            {
                Console.WriteLine("This class doesn't exist.");
            }
            info.Add(new DeparturesPlans(inputTime, inputCity, inputNumber, inputStatus, inputTerminal, inputcLass, Passenger.AllPassengers));
        }

        public override void Delete(List<LineInfo> info)
        {
            bool check;
            int num;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Which flight do you want to delete?");
            Console.ResetColor();
            Show(info);
            Console.WriteLine("Enter a figure.");
            check = int.TryParse(Console.ReadLine(), out num);
            if (check && info.Count > num)
            {
                info.Remove(info[num - 1]);
                Console.WriteLine("Flight #{0} removed ", num);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
        public override void Edit(List<LineInfo> info)
        {
            Random r = new Random();
            bool check;
            int num;
            int whatToChange;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Which flight do you want to change?");
            Console.ResetColor();
            Show(info);
            Console.WriteLine("Enter a figure.");
            check = int.TryParse(Console.ReadLine(), out num);
            DateTime inputTime = new DateTime(2016, r.Next(7, 12), r.Next(1, 29), r.Next(0, 24), r.Next(0, 60), r.Next(0, 60));
            Number inputNumber;
            Status inputStatus;
            Terminal inputTerminal;
            Class inputcLass;

            Console.WriteLine("Do you want to change the time? \n 1. Yes! 2. No!");
            check = int.TryParse(Console.ReadLine(), out whatToChange);
            if (whatToChange == 1)
            {
                info[num - 1].Time = inputTime;

            }
            else if (whatToChange != 2 && !check)
            {
                Console.WriteLine("Incorrect input");
            }
            Console.WriteLine("To what city is the flight?");
            string city = (Console.ReadLine());
            if (string.Empty == city)
            {
                Console.WriteLine("You didn't set any data.");
                return;
            }
            else { info[num - 1].City = city; }
            Console.WriteLine("Of which airlines is the flight? 1) {0} 2) {1} 3) {2} 4) {3} ", Number.FF148, Number.AC12G, Number.LN45P, Number.PG313);
            check = Enum.TryParse(Console.ReadLine(), out inputNumber);
            if (!check)
            {
                Console.WriteLine("This flight doesn't exist.");
            }
            else
            {
                info[num - 1].Number = inputNumber;
            }
            Console.WriteLine("Of which status is the flight? 1) {0} 2) {1} 3) {2} 4) {3} 5) {4} 6) {5} 7) {6} 8) {7}", Status.Boarding, Status.Canceled, Status.Checkin, Status.Departed, Status.Expected
               , Status.Landed, Status.OnTime, Status.Unknown);
            check = Enum.TryParse(Console.ReadLine(), out inputStatus);
            if (!check)
            {
                Console.WriteLine("This status doesn't exist.");
            }
            else
            {
                info[num - 1].Status = inputStatus;
            }
            Console.WriteLine("Of which terminal is the flight? 1) {0} 2) {1} 3) {2} 4) {3} 5) {4} 6) {5} ", Terminal.first, Terminal.second, Terminal.third, Terminal.fourth, Terminal.fifth, Terminal.sixth);
            check = Enum.TryParse(Console.ReadLine(), out inputTerminal);
            if (!check)
            {
                Console.WriteLine("This terminal doesn't exist.");
            }
            else
            {
                info[num - 1].Terminal = inputTerminal;
            }
            Console.WriteLine("Of which class is the flight? 1) {0} 2) {1} 3) {2} 4) {3}", Class.A, Class.B, Class.C, Class.D);
            check = Enum.TryParse(Console.ReadLine(), out inputcLass);
            if (!check)
            {
                Console.WriteLine("This class doesn't exist.");
            }
            else
            {
                info[num - 1].Class = inputcLass;
            }
        }
    }
}