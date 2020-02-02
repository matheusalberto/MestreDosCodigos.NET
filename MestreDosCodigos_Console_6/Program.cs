using System;

namespace MestreDosCodigos_Console_6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //A palavra-chave ref é usado para passar um argumento como uma referência. Isto significa que 
            //quando o valor do referido parâmetro é mudado no método, que se reflete no método de chamada. 
            //Um argumento que é passado usando uma palavra-chave ref deve ser inicializado no método de chamada antes de ser passado 
            //para o método chamado.
            int valorRef = 100;
            ExemploRef(ref valorRef);
            Console.WriteLine(valorRef);

            //A palavra-chave out também é usada para passar um argumento como  a palavra-chave ref, mas o argumento pode ser passado sem atribuir qualquer valor a ela.
            //    Um argumento que é passado usando uma palavra-chave out 
            //deve ser inicializado no método antes de retornar a chamada do mesmo.
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
