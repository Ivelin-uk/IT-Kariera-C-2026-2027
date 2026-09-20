using System.IO.Pipes;

namespace Demo_02
{
    static public class Arithmetics
    {
        public static double PI = 3.14;
        public static int Max(int n1, int n2)
        {
           return Math.Max(n1,n2);
        }
        public static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Add(int n1, double n2)
        {
            return n1 + n2;
        }

        public static double Add(double n1, int n2)
        {
            return n1 + n2;
        }

        public static double Add(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public static int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}