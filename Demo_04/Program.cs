
using System.Data;
using System.Xml;

namespace Demo_04
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            for(int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                list.Add(number);
            }

            Console.WriteLine("Sum = " + list.Sum());
            Console.WriteLine("Min = " + list.Min());
            Console.WriteLine("Max = " + list.Max());
            Console.WriteLine("Average = " + list.Average());
            /*
                Sum = 72
                Min = -5
                Max = 37
                Average = 14.4
            */

        }
    }
}
