using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_03
{
    public class MyArr
    {
        public static int GetSumElementsInArray(int[] array)
        {

            return array.Sum();
            // int sum = 0;
            // for(int i = 0; i < array.Length; i++)
            // {
            //     int currentElement = array[i];
            //     sum += currentElement;
            // }


            // return sum;
        }

        public static int[] FilterEvenNumber(int[] array)
        {

            // int counter = 0;
            // for(int i = 0; i < array.Length; i++)
            // {
            //     int currentElement = array[i];
            //     if(currentElement % 2 == 0)
            //     {
            //         counter++;
            //     }        
            // }

            // int[] newArray = new int[counter];

            // for(int i = 0; i < counter; i++)
            // {
            //     int currentElement = array[i];
            //     if(currentElement % 2 == 0)
            //     {
            //         newArray[i] = currentElement;
            //     }        
            // }
            return array.Where(a => a % 2 == 0).ToArray();

            //return newArray;
        }

        public static void PrintArray(int[] array)
        {
            Console.WriteLine("-----------------");
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"index {i} value: {array[i]} ");
            }
            Console.WriteLine("-----------------");
        }

        public static void PrintArray(string[] array)
        {
            Console.WriteLine("-----------------");
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"index {i} value: {array[i]} ");
            }
            Console.WriteLine("-----------------");
        }

        public static void PrintList(List<int> array)
        {
            Console.WriteLine("-----------------");
            for(int i = 0; i < array.Count; i++)
            {
                Console.WriteLine($"index {i} value: {array[i]} ");
            }
            Console.WriteLine("-----------------");
        }
    }
}