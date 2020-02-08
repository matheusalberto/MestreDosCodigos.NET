using System;
using System.Collections.Generic;
using System.Text;

namespace MestreDosCodigos_POO_Conceitos.Polimorfismo
{
    public class Veiculo
    {
        public string Tipo { get; set; }

        public Veiculo(string tipo)
        {
            this.Tipo = tipo;
        }

        public virtual void Mover() { }
        public virtual void Parar() { }
    }
}
