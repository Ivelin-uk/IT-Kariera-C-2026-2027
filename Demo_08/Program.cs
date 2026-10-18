
using System.Data;
using System.Xml;
using System.Linq;
using Lectures;

namespace Demo_08
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //string s = System.Console.ReadLine();
    
                //int.Parse(s);
                //Console.WriteLine("You entered a valid Int32 number {0}.", s);
                Person p = new Person();
                p.Age = 0;

                // Console.WriteLine(p.Age);   

                // int a = 10;
                // int b = 0;

                // int c = a / b;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("DivideByZeroException");
                Console.WriteLine(e.Message);
            }
            catch(ArithmeticException e)
            {
                Console.WriteLine("ArithmeticException");
                Console.WriteLine(e.Message);
            }
            catch(AgeException e)
            {
                Console.WriteLine("AgeException");
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception");
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
