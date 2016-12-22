using System;
using System.Collections.Generic;

namespace Airports
{
    class ShowArriveFlights : IMenuActioncs
    {
        public void Show(ArrivalsPlans arr, DeparturesPlans dep, List<LineInfo> allFlights)
        {
            Console.Clear();
            arr.Show(allFlights);
        }
    }
}