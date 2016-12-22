using System;
using System.Collections.Generic;

namespace Airports
{
    abstract class LineInfo
    {
        public int Price { get; set; }
        public DateTime Time { get; set; }
        public string City { get; set; }
        public Number Number { get; set; }
        public Class Class { get; set; }
        public Status Status { get; set; }
        public Terminal Terminal { get; set; }
        public Info Info { get; set; }
        public List<Passenger> passengers = new List<Passenger>();

        public abstract void Show(List<LineInfo> info);
        public abstract void Create(List<LineInfo> info);
        public abstract void Delete(List<LineInfo> info);
        public abstract void Edit(List<LineInfo> info);

        public override string ToString()
        {
            return string.Format(
@"  Cost: {0}
    Time: {1}
    City: {2}
    Airline: {3}
    Status: {4}
    Terminal: {5}
    Flight: {6}
    Class: {7}
    Number of passengers: {8}"
, Price, Time, City, Number, Status, Terminal, Info, Class, passengers.Count);
        }
    }
}