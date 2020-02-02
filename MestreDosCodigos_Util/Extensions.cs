using System;

namespace MestreDosCodigos_Util
{
    public static class Extensions
    {
        public static bool isPair(this int number) => (number % 2 == 0);
        public static int toInt(this string stringIntValue) => Convert.ToInt32(stringIntValue);
        public static double toDouble(this string stringDoubleValue) => Convert.ToDouble(stringDoubleValue);
        public static bool isMultipleThree(this int number) => (number % 3 == 0);
    }
}
