using System.Collections;
using System.Collections.Generic;

namespace MestreDosCodigos_POO_1_Conceitos.ExemplosInterfaces.Enumerable
{
    public class Cesta : IEnumerable
    {
        public List<string> Frutas { get; private set; }

        public Cesta(string[] frutas) => Frutas = new List<string>(frutas);

        public IEnumerator GetEnumerator()
        {
            return Frutas.GetEnumerator();
        }
    }
}
