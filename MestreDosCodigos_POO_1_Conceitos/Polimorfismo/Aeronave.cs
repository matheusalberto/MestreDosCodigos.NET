using System;

namespace MestreDosCodigos_POO_1_Conceitos.Polimorfismo
{
    public class Aeronave : Veiculo
    {
        public Aeronave(string tipo) : base(tipo) { }

        public override void Mover()
        {
            Console.WriteLine("Decolando a aeronave");
        }
        public override void Parar()
        {
            Console.WriteLine("Pousando a aeronave");
        }
    }
}
