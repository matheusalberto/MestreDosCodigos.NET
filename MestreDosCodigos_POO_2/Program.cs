using MestreDosCodigos_POO_2.Model;
using System;

namespace MestreDosCodigos_POO_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa();
            pessoa.SetNome("José Pereira");
            pessoa.SetAltura(170);
            pessoa.SetDataNascimento(new DateTime(1995, 12, 12));

            pessoa.MostrarDados();
            Console.Write($"Idade: {pessoa.GetIdade()}");
        }
    }
}
