using System.Data;
using System.Xml;

namespace Demo_02
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            //Math.Max(2,3);
            //Console.WriteLine("work");
            

            //Arithmetics Arithmetics1 = new Arithmetics();
            //Arithmetics1.test1();
            


            // Console.WriteLine(Arithmetics.Max(2,4));
            // Console.WriteLine(Arithmetics.PI);
            // Console.WriteLine(Arithmetics.Add(33,33));
            // Console.WriteLine(Arithmetics.Multiply(3,3));

            Person p1 = new Person();
            Person p2 = new Person();
            Person p3 = new Person();
            Person p4 = new Person();

            Person p5 = new Person("Ivan",2);

            Person p6 = new Person("UKTC","Sofia");

            Console.WriteLine(Person.Count);
        }

        public static void test1()
        {
            
        }
    }
}
