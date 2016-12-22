using System.Collections.Generic;

namespace Airports
{
    class ShowPassengers : IMenuActioncs
    {
        public void Show(ArrivalsPlans arr, DeparturesPlans dep, List<LineInfo> allFlights)
        {
            Passenger.Show(Passenger.AllPassengers);
        }
    }
}