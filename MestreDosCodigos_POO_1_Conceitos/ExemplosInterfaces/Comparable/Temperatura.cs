using System;

namespace MestreDosCodigos_POO_1_Conceitos.ExemplosInterfaces.Comparable
{
    public class Temperatura : IComparable
    {
        protected double TemperaturaF;

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Temperatura outraTemperatura = obj as Temperatura;
            if (outraTemperatura != null)
                return TemperaturaF.CompareTo(outraTemperatura.TemperaturaF);
            else
                throw new ArgumentException("Objeto inválido, não é temperatura");
        }

        public double Fahrenheit
        {
            get
            {
                return TemperaturaF;
            }
            set
            {
                TemperaturaF = value;
            }
        }
    }
}
