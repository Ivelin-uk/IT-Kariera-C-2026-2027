namespace Demo_11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                using (var reader = new StreamReader("names.cs"))
                {
                    
                }   
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
