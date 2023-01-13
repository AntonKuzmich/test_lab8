namespace Transcompany.Buses
{
    public class PassengerBus : Bus
    {
        private int _passengersCapacity;

        public PassengerBus(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, int passengersCapacity)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity) => _passengersCapacity = passengersCapacity;

        public int PassengersCapacity => _passengersCapacity;

        public override bool Equals(object obj)
        {
            var Bus = obj as PassengerBus;
            return Bus != null && base.Equals(obj) && _passengersCapacity == Bus._passengersCapacity;
        }

        public override int GetHashCode()
        {
            var hashCode = 751774561;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + _passengersCapacity.GetHashCode();
            return hashCode;
        }

        public override string ToString() => $"Passenger {base.ToString()}, passengersCapacity = {_passengersCapacity}";
    }
}
