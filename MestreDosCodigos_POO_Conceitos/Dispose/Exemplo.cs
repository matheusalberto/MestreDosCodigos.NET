using System;

namespace MestreDosCodigos_POO_Conceitos.Dispose
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
