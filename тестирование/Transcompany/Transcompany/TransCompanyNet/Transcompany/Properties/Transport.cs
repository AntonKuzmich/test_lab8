using Transcompany.Buses;
namespace Transcompany
{
    public class Transport
    {
        private List<Bus> _Buses;

        public Transport(IEnumerable<Bus> Buses) => _Buses = Buses.ToList();

        public List<Bus> Buses => _Buses;

        public List<PassengerBus> GetPassengerBuses()
        {
            var PassengerBuses = new List<PassengerBus>();
            foreach (var Bus in _Buses)
                if (Bus is PassengerBus)
                    PassengerBuses.Add(Bus as PassengerBus);
            return PassengerBuses;
        }

        public PassengerBus GetPassengerBusWithMaxPassengersCapacity() =>
           GetPassengerBuses().Aggregate((m, c) => m.PassengersCapacity > c.PassengersCapacity ? m : c);

        public Transport SortByMaxDistance() => new Transport(_Buses.OrderBy(p => p.MaxFlightDistance));

        public Transport SortByMaxSpeed() => new Transport(_Buses.OrderBy(p => p.MaxSpeed));

        public Transport SortByMaxLoadCapacity() => new Transport(_Buses.OrderBy(p => p.MaxLoadCapacity));

        public override string ToString() => $"Transport: Buses = {string.Join(", ", _Buses.Select(x => x.Model))}\n";
    }
}
