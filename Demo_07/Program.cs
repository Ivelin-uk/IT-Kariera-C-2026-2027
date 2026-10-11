
using System.Data;
using System.Xml;
using System.Linq;

namespace Demo_07
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            // string words = "In SoftUni you can study Java, C#, PHP and JavaScript. JAVA and c# developers graduate in 2-3 years. Go in!";

            // char[] separators = new char[]{'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '};

            // string[] splitWords = words.Split(separators);

            // splitWords = splitWords.Where(word => word != "").ToArray();

            // splitWords = splitWords.Where(word => word.Length < 5).ToArray();

            // //A - Z
            // splitWords = splitWords.OrderBy(e => e).ToArray();

            // string[] words = "In SoftUni you can study Java, C#, PHP and JavaScript. JAVA and c# developers graduate in 2-3 years. Go in!"
            // .Split(new char[]{'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '})
            // .Where(word => word != "")
            // .Where(word => word.Length < 5)
            // .OrderBy(e => e)
            // .ToArray();

            // Console.WriteLine(String.Join(", ",words));

            // Action<string> print = message =>Console.WriteLine(message);

            // print("TEST");

            // List<int> input = "4, 2, 1, 3, 5, 7, 1, 4, 2, 12".Split(", ").Select(e => int.Parse(e)).Where(e => e % 2 == 0).ToList();
            // input = input.OrderBy(e => e).ToList();
            // Console.WriteLine(String.Join(", ",input));
            // Console.WriteLine($"Count {input.Count}");
            // Console.WriteLine($"Sum {input.Sum()}");

            string[] words = "The following example shows how to use Function".Split(" ");

            List<string> newWords = new List<string>();
            for(int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                char firstLetter = currentWord[0];
                if (char.IsUpper(firstLetter))
                {
                   newWords.Add(currentWord);
                }
            }

            Console.WriteLine(String.Join(", ",newWords));
            

        // private void Print(string message)
        // { 
        //     Console.WriteLine(message); 
        // }
    }

    public static List<string> FilterArray(string[] words)
    {
        List<string> newWords = new List<string>();
        for(int i = 0; i < words.Length; i++)
        {
            string currentWord = words[i];
            char firstLetter = currentWord[0];
            if (char.IsUpper(firstLetter))
            {
                newWords.Add(currentWord);
            }
        }

        return newWords;
    }
    }
}
