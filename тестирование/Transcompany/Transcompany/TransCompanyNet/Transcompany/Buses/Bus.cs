namespace Transcompany.Buses
{
    public abstract class Bus
    {
        private string _model;
        private int _maxSpeed;
        private int _maxFlightDistance;
        private int _maxLoadCapacity;

        public Bus() { }

        public Bus(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity)
        {
            _model = model;
            _maxSpeed = maxSpeed;
            _maxFlightDistance = maxFlightDistance;
            _maxLoadCapacity = maxLoadCapacity;
        }

        public string Model => _model;
        public int MaxSpeed => _maxSpeed;
        public int MaxFlightDistance => _maxFlightDistance;
        public int MaxLoadCapacity => _maxLoadCapacity;

        public override bool Equals(object obj)
        {
            var Bus = obj as Bus;
            return Bus != null &&
                   _model == Bus._model &&
                   _maxSpeed == Bus._maxSpeed &&
                   _maxLoadCapacity == Bus._maxLoadCapacity &&
                   _maxFlightDistance == Bus._maxFlightDistance;
        }

        public override int GetHashCode()
        {
            var hashCode = -1043886837;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_model);
            hashCode = hashCode * -1521134295 + _maxSpeed.GetHashCode();
            hashCode = hashCode * -1521134295 + _maxFlightDistance.GetHashCode();
            hashCode = hashCode * -1521134295 + _maxLoadCapacity.GetHashCode();
            return hashCode;
        }

        public override string ToString() => $"Bus: model = \'{_model}\', maxSpeed = {_maxSpeed}" +
                $", maxFlightDistance = {_maxFlightDistance}, maxLoadCapacity = {_maxLoadCapacity}";
    }
}
