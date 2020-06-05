using System;

namespace MestreDosCodigos_POO_1_Conceitos.ExemplosInterfaces.Cloneable
{
    public class Pessoa : ICloneable
    {
        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }
        private string Nome { get; set; }
        private string Sobrenome { get; set; }
        private int Idade { get; set; }

        public object Clone() => new Pessoa(Nome, Sobrenome, Idade);
    }
}
