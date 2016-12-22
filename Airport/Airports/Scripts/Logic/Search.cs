using System;
using System.Collections.Generic;

namespace Airports
{
    class Search
    {
        public static void SearchByElement(LineInfo info, List<LineInfo> allFlights)
        {
            LineInfo line1;
            int menu;
            bool check;
            Console.Clear();
            Console.WriteLine(@"Search menu");
            Console.WriteLine(
                "For some categories, you want to make a search?\n" +
                "\n1)City \n2)Number airline \n3)Status \n4)Terminal \n5)Class \n6)Passenger \n7)Cost");
            check = int.TryParse(Console.ReadLine(), out menu);
            switch (menu)
            {
                case 1:
                    info.Show(SearchByCity(allFlights));
                    break;
                case 2:
                    info.Show(SearchByNumber(allFlights));
                    break;
                case 3:
                    info.Show(SearchByStatus(allFlights));
                    break;
                case 4:
                    info.Show(SearchByTerminal(allFlights));
                    break;
                case 5:
                    info.Show(SearchByClass(allFlights));
                    break;
                case 6:
                    info.Show(SearchByPassenger(allFlights));
                    break;
                case 7:
                    info.Show(SearchByPriece(allFlights));
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }
        private static List<LineInfo> SearchByCity(List<LineInfo> info)
        {
            List<LineInfo> flights = new List<LineInfo>();
            Console.WriteLine("Please, select city");
            string city = Console.ReadLine();
            foreach (var i in info)
            {
                if (city == i.City)
                {
                    flights.Add(i);
                }
            }
            if (flights.Count == 0)
            {
                Console.WriteLine("We are sorry, but nothing has been found");
            }
            return flights;
        }
        private static List<LineInfo> SearchByNumber(List<LineInfo> info)
        {
            bool temp;
            Number number;
            List<LineInfo> flights = new List<LineInfo>();
            Console.WriteLine("Please, enter number airline");
            temp = Enum.TryParse(Console.ReadLine(), out number);
            if (!temp)
            {
                Console.WriteLine("We are sorry, but nothing has been found");
            }
            else
            {
                foreach (var i in info)
                {
                    if (number == i.Number)
                    {
                        flights.Add(i);
                    }
                }
            }
            return flights;
        }

        private static List<LineInfo> SearchByStatus(List<LineInfo> info)
        {
            bool temp;
            Status status;
            List<LineInfo> flights = new List<LineInfo>();
            Console.WriteLine("Please, enter status");
            temp = Enum.TryParse(Console.ReadLine(), out status);
            if (!temp)
            {
                Console.WriteLine("We are sorry, but nothing has been found");
            }
            else
            {
                foreach (var i in info)
                {
                    if (status == i.Status)
                    {
                        flights.Add(i);
                    }
                }
            }
            return flights;
        }

        private static List<LineInfo> SearchByTerminal(List<LineInfo> info)
        {
            bool temp;
            Terminal terminal;
            List<LineInfo> flights = new List<LineInfo>();
            Console.WriteLine("Please, enter terminal");
            temp = Enum.TryParse(Console.ReadLine(), out terminal);
            if (!temp)
            {
                Console.WriteLine("We are sorry, but nothing has been found");
            }
            else
            {
                foreach (var i in info)
                {
                    if (terminal == i.Terminal)
                    {
                        flights.Add(i);
                    }
                }
            }
            return flights;
        }

        private static List<LineInfo> SearchByClass(List<LineInfo> info)
        {
            bool temp;
            Class Class;
            List<LineInfo> flights = new List<LineInfo>();
            Console.WriteLine("Please, enter class");
            temp = Enum.TryParse(Console.ReadLine(), out Class);
            if (!temp)
            {
                Console.WriteLine("We are sorry, but nothing has been found");
            }
            else
            {
                foreach (var i in info)
                {
                    if (Class == i.Class)
                    {
                        flights.Add(i);
                    }
                }
            }
            return flights;
        }

        private static List<LineInfo> SearchByPassenger(List<LineInfo> info)
        {
            List<LineInfo> flights = new List<LineInfo>();
            Console.WriteLine("Please, enter the passenger name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please, enter the passenger surname");
            string secondName = Console.ReadLine();

            foreach (var i in info)
            {
                if (i.passengers.Exists(x => x.FirstName == firstName) && i.passengers.Exists(x => x.SecondName == secondName))
                {
                    flights.Add(i);
                }
            }
            if (flights.Count == 0)
            {
                Console.WriteLine("We are sorry, but nothing has been found");
            }

            return flights;
        }

        private static List<LineInfo> SearchByPriece(List<LineInfo> info)
        {
            bool temp;
            int money;
            List<LineInfo> flights = new List<LineInfo>();
            Console.WriteLine("Enter a minimum sum you expect to");
            temp = int.TryParse(Console.ReadLine(), out money);
            if (!temp)
            {
                Console.WriteLine("Incorrect input");
            }
            foreach (var i in info)
            {
                if (i.Price < money)
                {
                    flights.Add(i);
                }
            }
            if (flights.Count == 0)
            {
                Console.WriteLine("We are sorry, but nothing has been found");
            }
            return flights;
        }
    }
}