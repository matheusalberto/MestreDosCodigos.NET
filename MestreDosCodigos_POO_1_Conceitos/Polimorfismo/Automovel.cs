using System;

namespace MestreDosCodigos_POO_1_Conceitos.Polimorfismo
{
    public class Automovel : Veiculo
    {
        public Automovel(string tipo) : base(tipo) { }

        public override void Mover()
        {
            Console.WriteLine("Acelerando o automóvel");
        }
        public override void Parar()
        {
            Console.WriteLine("Freiando o automóvel");
        }
    }
}
