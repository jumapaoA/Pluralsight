using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.ArraysCollections.Demos
{
    public class Bus
    {
        public const int Capacity = 5;
        public int Space { get => Capacity - _passengers.Count; }

        private List<Passenger> _passengers = new List<Passenger>();
        public bool Load(Passenger passenger)
        {
            if (Space < 1)
                return false;

            _passengers.Add(passenger);
            Console.WriteLine($"{passenger} got on the bus");
            return true;
        }

        public void ArriveAt(string place)
        {
            Console.WriteLine($"\r\nBus arriving at {place}");
            if (_passengers.Count == 0)
                return;

            List<Passenger> found = _passengers.FindAll(route => route.Destination == place); 
            for(int i=0; i<found.Count; i++)
            {
                Console.WriteLine($"{found[i]} is getting off");
                _passengers.Remove(found[i]);
            }

            Console.WriteLine($"{_passengers.Count} people left on the bus");
        }
    }
}
