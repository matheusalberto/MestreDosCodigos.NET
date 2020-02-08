using System;

namespace MestreDosCodigos_POO_1_Conceitos.Dispose
{
    public class Exemplo : IDisposable
    {
        public void Dispose()
        {
            //Os recursos do objeto serão liberados.
            Dispose();
        }
    }
}
