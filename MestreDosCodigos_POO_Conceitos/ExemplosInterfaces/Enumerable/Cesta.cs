using System.Collections;
using System.Collections.Generic;

namespace MestreDosCodigos_POO_Conceitos.ExemplosInterfaces.Enumerable
{
    public class Cesta : IEnumerable
    {
        List<string> Frutas;

        public Cesta(string[] frutas) => Frutas = new List<string>(frutas);

        public IEnumerator GetEnumerator()
        {
            return this.Frutas.GetEnumerator();
        }
    }
}
