using System;
using System.IO;

namespace MestreDosCodigos_POO_1_Conceitos.ExemplosInterfaces.Disposable
{
    public class LogWriter : IDisposable
    {
        // booleano para controlar se
        // o método Dispose já foi chamado
        bool disposed = false;

        private StreamWriter m_Stream;

        public LogWriter(string logFile)
        {
            m_Stream = new StreamWriter(logFile, true);
            m_Stream.WriteLine("Iniciando o log às {0}", DateTime.Now);
        }

        ~LogWriter()
        {
            Dispose(false);
        }

        public void WriteLine(string message)
        {
            m_Stream.WriteLine(message);
        }

        // método privado para controle
        // da liberação dos recursos
        protected void Dispose(bool disposing)
        {
            // Verifique se Dispose já foi chamado, evitando liberar o recurso 2x
            if (!disposed)
            {
                if (disposing)
                {
                    // Liberando recursos gerenciados
                    m_Stream.Dispose();
                }

                // Seta a variável booleana para true,
                // indicando que os recursos já foram liberados
                disposed = true;
            }
        }
        
        public void Dispose()
        {
            Dispose(true);

            // Este códgo indica que o garbagge collector não deve chamar o método 
            // finalizador da classe, pois estamos controlando isso manualmente
            GC.SuppressFinalize(this);
        }
    }
}
