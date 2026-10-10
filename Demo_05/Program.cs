
using System.Data;
using System.Xml;
using System.Linq;

namespace Demo_05
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            //int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int sum = n.Sum();
            //for (int i = 0; i < n.Length; i++)
            //{
            //    sum += n[i];
            //}
            //Console.WriteLine(sum);

            Car car1 = new Car("BMW",100);
            Car car2 = new Car("Seat",300);
            Car car3 = new Car("VW",200);
            Car car4 = new Car("Schoda",333);
            Car car5 = new Car("Schoda",150);


            Motor Motor1 = new Motor("Yamaha",10);
            Motor Motor2 = new Motor("Yamaha",20);
            Motor Motor3 = new Motor("Yamaha",15);
            Motor Motor4 = new Motor("Yamaha",33);

           // List<Motor> motors = new List<Motor>();
           // List<Car> cars = new List<Car>();

            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(car1);
            vehicles.Add(car2);
            vehicles.Add(car3);
            vehicles.Add(car4);
            vehicles.Add(car5);

            vehicles.Add(Motor1);
            vehicles.Add(Motor2);
            vehicles.Add(Motor3);
            vehicles.Add(Motor4);

            var newVehicles = vehicles.Where(v => v.Brand == "BMW").ToList();

            // cars.Add(car1);
            // cars.Add(car2);
            // cars.Add(car3);
            // cars.Add(car4);

            // var doubledHp = cars.Select(car => car.Hp * 2).ToList();
            // cars = cars.Where(car => car.Hp > 300).ToList();

            print(newVehicles);

        }

        public static void print(List<Vehicle> vehicles)
        {
            Console.WriteLine("vehicles");
            for(int i = 0; i < vehicles.Count; i++)
            {
                Vehicle currentCar = vehicles[i];
                System.Console.WriteLine($"Brand: {currentCar.Brand} HP: {currentCar.Hp}");
            }
        }
    }
}
