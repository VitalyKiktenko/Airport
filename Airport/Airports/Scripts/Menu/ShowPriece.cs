using System.Collections.Generic;

namespace Airports
{
    class ShowPriece : IMenuActioncs
    {
        public void Show(ArrivalsPlans arr, DeparturesPlans dep, List<LineInfo> allFlights)
        {
            Prices.Show();
        }
    }
}