using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.ArraysCollections.Demos
{
    public class BusStop
    {
        private List<Passenger> _peopleWaiting = new List<Passenger>();
        public void PersonArrive(Passenger passenger)
        {
            _peopleWaiting.Add(passenger);
            Console.WriteLine($"{passenger} queuing at bus stop");
        }
        public void BusArrive(Bus bus)
        {
            Console.WriteLine("\r\nBus arriving at bus stop to load passengers");
            while (bus.Space > 0 && _peopleWaiting.Count > 0)
            {
                Passenger passenger = _peopleWaiting[0];
                _peopleWaiting.RemoveAt(0);
                bus.Load(passenger);
            }
        }
    }
}
