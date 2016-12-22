using System;

namespace Airports
{
    class Cities
    {
        static readonly Random random = new Random();

        public string TakeCity()
        {
            string route = "";
            string startCity;
            string finishCity;
            string[] someCities = { "Kharkov", "Kiev", "Berlin", "Paris", "Milan", "Madrid", "Moscow", "London", "New York", "Ede", "Amsterdam", "Rome", "Depok", "Pekin" };
            do
            {
                startCity = someCities[random.Next(0, 14)];
                finishCity = someCities[random.Next(0, 14)];

            } while (startCity == finishCity);
            return route = "from " + startCity + " to " + finishCity;
        }
    }
}