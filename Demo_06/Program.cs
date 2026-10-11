
using System.Data;
using System.Xml;
using System.Linq;

namespace Demo_06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Car car1 = new Car("VW",120);
            // Car car2 = new Car("Seat",90);
            // Car car3 = new Car("BMW",299);
            // Car car4 = new Car("VW",100);
            // Car car5 = new Car("Opel",120);

            // List<Car> cars = new List<Car>();
            // cars.Add(car1);
            // cars.Add(car2);
            // cars.Add(car3);
            // cars.Add(car4);
            // cars.Add(car5);

            //Print(cars);
            //cars = cars.OrderBy(car => car.Hp).ThenBy(car => car.Brand).ToList();
            //Print(cars);
        
            //List<int> numbers = new List<int>{ 1, 5, 2, 4, 3 };
            //numbers = numbers.OrderBy(e => e).ToList();

            //var newNum = nums.Select(e => e * 2).ToList();


            //System.Console.WriteLine(String.Join(", ",numbers));

            // Dictionary<string, Car> dictionaryCars = new Dictionary<string, Car>();
            // dictionaryCars.Add("AS3332DD",car1);
            // dictionaryCars.Add("DDA322DD",car2);
            // dictionaryCars.Add("NN2223VV",car3);
            // dictionaryCars.Add("AGG2222D",car4);
            // dictionaryCars.Add("HH222DD2",car5);

            // dictionaryCars = dictionaryCars.OrderBy(pair => pair.Value.Hp).ToDictionary(pair => pair.Key, pair => pair.Value);
            // PrintDic(dictionaryCars);

            List<int> number = Console.ReadLine().Split(' ').Select(e => int.Parse(e)).OrderByDescending(e => e).ToList();

            number = number.Take(3).ToList();
            Console.WriteLine(String.Join(", ",number));

        }

        public static void PrintDic(Dictionary<string, Car> dictionaryCars)
        {
           foreach (var ele in dictionaryCars){
            Console.WriteLine($"NUMBER: {ele.Key}, CAR: Brand - {ele.Value.Brand} Hp - {ele.Value.Hp} ");
        }
        }

        public static void Print(List<Car> cars)
        {
            for(int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"Brand {cars[i].Brand} Hp: {cars[i].Hp}");
            }
        }
    }
}
