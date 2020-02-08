using MestreDosCodigos_Util;
using System;

namespace MestreDosCodigos_Console_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite A:");
            var strA = Console.ReadLine();

            Console.Write("Digite B:");
            var strB = Console.ReadLine();

            Console.Write("Digite C:");
            var strC = Console.ReadLine();

            try
            {
                int a = strA.toInt();
                int b = strB.toInt();
                int c = strC.toInt();

                var delta = Math.Sqrt(b * b - 4 * a * c);

                var r1 = (-b + delta) / 2 * a;
                var r2 = (-b - delta) / 2 * a;

                Console.WriteLine(string.Format("R1: {0}", r1));
                Console.WriteLine(string.Format("R2: {0}", r2));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
