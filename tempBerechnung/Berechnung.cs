using System;


namespace tempBerechnung
{
    public class Berechnung
    {
        public static double CnachF(double grad)
        {
            return grad * 1.8 + 32;
        }

        public static double FnachC(double grad)
        {
            return (grad - 32)/1.8;
        }
    }
}
