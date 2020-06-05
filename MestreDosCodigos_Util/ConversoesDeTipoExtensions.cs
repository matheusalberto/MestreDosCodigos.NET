using System;

namespace MestreDosCodigos_Util
{
    public static class ConversoesDeTipoExtensions
    {
        public static int ToInt(this string stringIntValue) => Convert.ToInt32(stringIntValue);
        public static double ToDouble(this string stringDoubleValue) => Convert.ToDouble(stringDoubleValue);
    }
}
