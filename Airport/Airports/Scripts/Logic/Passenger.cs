using System;
using System.Collections.Generic;

namespace Airports
{
    class Passenger
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime DateofBirthday { get; set; }
        public Number FlightNumber { get; set; }
        public Class Class { get; set; }
        public Sex Gender { get; set; }
        public string Passport { get; set; }
        public static List<Passenger> AllPassengers = new List<Passenger>();

        public Passenger() { }

        public Passenger(string firstname, string secondname, DateTime dateofbithday, Number flightnumber, Class cLass, Sex gender, string passport)
        {
            this.FirstName = firstname;
            this.SecondName = secondname;
            this.DateofBirthday = dateofbithday;
            this.FlightNumber = flightnumber;
            this.Class = cLass;
            this.Gender = gender;
            this.Passport = passport;
        }

        public static void CreatePassenger()
        {
            Random r = new Random();
            bool check;
            string inputFirstnam;
            string inputSecondname;
            string firstname;
            DateTime inputDateofbithday = new DateTime(r.Next(1960, 2009), r.Next(1, 12), r.Next(1, 29), r.Next(0, 24), r.Next(0, 60), r.Next(0, 60));
            Number inputFlightnumber;
            Class inputinputcLass;
            Sex inputGender;
            string inputPassport;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Create passenger");
            Console.ResetColor();
            Console.WriteLine("Enter the name of the passenger");
            firstname = (Console.ReadLine());

            if (string.Empty == firstname)
            {
                Console.WriteLine("You didn't set any data.");
                return;
            }
            else
            {
                inputFirstnam = firstname;
            }

            Console.WriteLine("Enter the surname of the passenger");
            string secondname = (Console.ReadLine());
            if (string.Empty == secondname)
            {
                Console.WriteLine("You didn't set any data.");
                return;
            }
            else
            {
                inputSecondname = secondname;
            }
            Console.WriteLine("Select airline 1) {0} 2) {1} 3) {2} 4) {3} "
                , Number.FF148, Number.AC12G, Number.LN45P, Number.PG313);
            check = Enum.TryParse(Console.ReadLine(), out inputFlightnumber);
            if (!check)
            {
                Console.WriteLine("This flight doesn't exist.");
            }
            Console.WriteLine("Select class 1) {0} 2) {1} 3) {2} 4) {3} ", Class.A, Class.B, Class.C, Class.D);
            check = Enum.TryParse(Console.ReadLine(), out inputinputcLass);
            if (!check)
            {
                Console.WriteLine("This class doesn't exist.");
            }
            Console.WriteLine("Enter the sex of the passenger 1) {0} 2) {1} ", Sex.Female, Sex.Male);
            check = Enum.TryParse(Console.ReadLine(), out inputGender);
            if (!check)
            {
                Console.WriteLine("This sex doesn't exist.");
            }
            Console.WriteLine("Select the passenger nationality");
            string passport = (Console.ReadLine());
            if (string.Empty == passport)
            {
                Console.WriteLine("You didn't set any data.");
                return;
            }
            else
            {
                inputPassport = passport;
            }
            AllPassengers.Add(new Passenger(inputFirstnam, inputSecondname, inputDateofbithday, inputFlightnumber, inputinputcLass, inputGender, inputPassport));
        }

        public static void Show(List<Passenger> passenger)
        {
            foreach (var p in passenger)
            {
                Console.WriteLine(p.ToString());
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            return string.Format("| {0,-15}| {1,-20}| {2,-25}| {3,-5} | {4,-5}| {5,-10} {6,-25}|", this.FirstName, this.SecondName, this.DateofBirthday, this.FlightNumber, this.Class, this.Gender, this.Passport);
        }

        public static void GetPassenger(List<Passenger> arr)
        {
            Random r = new Random();
            string name;
            string sname;
            string pass;
            DateTime date = new DateTime();
            string[] _Mnames = { "Adehi", "Viho", "Kangi", "Kotori", "Gilbert", "Damian", "Dirk" };
            string[] _Fnames = { "Aaren", "Adelpha", "Dana", "Lavina", "Less", "Merion", "Nella" };
            string[] _serNames = { "Murphy", "Nash", "Nathan", "Neal", "Addington", "Jacobson", "Oldridge" };
            string[] _passport = { "American", "French", "Italian", "Spanish" };

            for (int i = 0; i < 8; i++)
            {
                Number number = (Number)(r.Next(0, 4));
                Class cls = (Class)(r.Next(0, 4));
                Sex gen = (Sex)(r.Next(0, 2));
                if (gen == Sex.Male)
                {
                    name = _Mnames[r.Next(0, 7)];
                }
                else
                {
                    name = _Fnames[r.Next(0, 7)];
                }
                sname = _serNames[r.Next(0, 7)];
                date = new DateTime(r.Next(1960, 2009), r.Next(1, 12), r.Next(1, 29), r.Next(0, 24), r.Next(0, 60), r.Next(0, 60));
                pass = _passport[r.Next(0, 4)];
                arr.Add(new Passenger(name, sname, date, number, cls, gen, pass));
            }
        }
    }
}