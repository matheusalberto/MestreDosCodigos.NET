using System;

namespace MestreDosCodigos_Console_6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int valorRef = 100;
            ExemploRef(ref valorRef);
            Console.WriteLine(valorRef);

            int valorOut;
            ExemploOut(out valorOut);
            Console.WriteLine(valorOut);
        }

        public static void ExemploRef(ref int value)
        {
            value = 1;
        }
        public static void ExemploOut(out int value)
        {
            value = 10;
        }
    }
}
