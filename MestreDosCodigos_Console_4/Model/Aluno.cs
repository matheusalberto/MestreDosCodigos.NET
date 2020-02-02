namespace MestreDosCodigos_Console_4.Model
{
    public class Aluno
    {
        public Aluno(string nome, double nota)
        {
            Nome = nome;
            Nota = nota;
        }

        public bool TemNotaAzul() => Nota > 7;
        public string Nome { get; private set; }
        public double Nota { get; private set; }
    }
}
