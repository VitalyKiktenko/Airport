using System.Collections.Generic;

namespace Airports
{
    interface IMenuActioncs
    {
        void Show(ArrivalsPlans arr, DeparturesPlans dep, List<LineInfo> allFlights);
    }
}