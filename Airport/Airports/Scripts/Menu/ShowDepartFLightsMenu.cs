using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports
{
    class ShowDepartFLightsMenu : IMenuActioncs
    {
        public void Show(ArrivalsPlans arr, DeparturesPlans dep, List<LineInfo> allFlights)
        {
            Console.Clear();
            dep.Show(allFlights);
        }
    }
}