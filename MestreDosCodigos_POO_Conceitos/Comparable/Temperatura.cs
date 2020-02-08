using System;
using System.Collections;

public class Temperatura : IComparable
{
    protected double temperaturaF;

    public int CompareTo(object obj)
    {
        if (obj == null) return 1;

        Temperatura outraTemperatura = obj as Temperatura;
        if (outraTemperatura != null)
            return this.temperaturaF.CompareTo(outraTemperatura.temperaturaF);
        else
            throw new ArgumentException("Objeto inválido, não é temperatura");
    }

    public double Fahrenheit
    {
        get
        {
            return this.temperaturaF;
        }
        set
        {
            this.temperaturaF = value;
        }
    }

    public double Celsius
    {
        get
        {
            return (this.temperaturaF - 32) * (5.0 / 9);
        }
        set
        {
            this.temperaturaF = (value * 9.0 / 5) + 32;
        }
    }
}