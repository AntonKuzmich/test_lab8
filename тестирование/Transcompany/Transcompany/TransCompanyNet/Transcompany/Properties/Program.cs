using Transcompany.Buses;
using System.Text.Json;

namespace Transcompany
{
    public class Program
    {
        public static void Main()
        {
            var Buses = new List<Bus>();
            var PassengerBuses = new List<PassengerBus>();

            using (var streamReaderPassengerBusesJson = new StreamReader("C:\\Users\\anton\\OneDrive\\Desktop\\тестирование\\Transcompany\\Transcompany\\TransCompanyNet\\Transcompany\\JSON\\passengerBuses.json"))
            {
                PassengerBuses = JsonSerializer.Deserialize<List<PassengerBus>>(streamReaderPassengerBusesJson.ReadToEnd());
            }

            foreach (var Bus in PassengerBuses)
                Buses.Add(Bus);

            var Transport = new Transport(Buses);
            var passengerTransport = new Transport(Transport.GetPassengerBuses());

            Console.WriteLine(passengerTransport.SortByMaxSpeed());
            Console.WriteLine(passengerTransport.GetPassengerBusWithMaxPassengersCapacity());
        }
    }
}
