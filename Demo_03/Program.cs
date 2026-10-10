
using System.Data;
using System.Xml;

namespace Demo_03
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            // int[] array = new int[5];
            // array[0] = 2;
            // array[1] = 3;
            // array[2] = 3;
            // array[3] = 4;
            // array[4] = 3;

            // //Console.WriteLine("work");
            // //Hello();=

            // MyArr.PrintArray(array);

            // int[] newArrat = MyArr.FilterEvenNumber(array);

            // MyArr.PrintArray(newArrat);

            string input = "4, 2, 1, 3, 5, 7, 1, 4, 2, 12";

            //int[] arr = input.Split(", ").Select(element => int.Parse(element)).Where(element => element > 5).ToArray();
            // List<int> list = input.Split(", ").Select(element => int.Parse(element)).Where(element => element > 5).ToList();
            // list = list.Select(x => x / 2).ToList();
            
            //MyArr.PrintArray(arr);
            // MyArr.PrintList(list);

            //string[] splitInput =  input.Split(", ");

            // int[] splitInputAsNumber = new int[splitInput.Length];
            // for(int i = 0; i < splitInput.Length; i++)
            // {
            //     splitInputAsNumber[i] = int.Parse(splitInput[i]);
            // }

            // int[] splitInputAsNumber = splitInput.Select(x => int.Parse(x)).ToArray();
            // int sum = splitInputAsNumber.Sum();

            // Console.WriteLine(sum);

            //MyArr.PrintArray(splitInput);

            List<int> list = new List<int>() { 1, 2, 3, 4, -1, -5, 0, 50 };

            int sumList = list.Sum();
            int maxList = list.Max();
            int minList = list.Min();
            double averageList = list.Average();

       

        }

        public static void Hello()
        {
            
        }
    }
}
