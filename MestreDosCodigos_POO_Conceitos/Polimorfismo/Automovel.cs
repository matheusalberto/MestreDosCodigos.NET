using System;
using System.Collections.Generic;
using System.Text;

namespace MestreDosCodigos_POO_Conceitos.Polimorfismo
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
