namespace Demo_11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var reader = new StreamReader("Program.cs"))
            {
                using (var writer = new StreamWriter("file.txt"))
                {
                    string line = reader.ReadLine();
                    //Console.WriteLine(line.Length);
                    while (line != null)
                    {
                        //for (int i = line.Length - 1; i >= 0; i--)
                        //{
                            writer.Write(line[i]);
                        //}
                        writer.WriteLine();
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
