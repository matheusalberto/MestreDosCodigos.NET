using MestreDosCodigos_POO_10.Model;
using System;

namespace MestreDosCodigos_POO_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa();
            pessoa.setNome("José Pereira");
            pessoa.setAltura(170);
            pessoa.setDataNascimento(new DateTime(1995, 12, 12));

            pessoa.showDados();
            Console.Write(string.Format("Idade: {0}", pessoa.getIdade()));
        }
    }
}
