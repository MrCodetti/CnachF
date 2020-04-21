using System;


namespace tempBerechnung
{
    public class Berechnung
    {
        public static double CnachF(int grad)
        {
            return grad * 1.8 + 32;
        }

        public static double FnachC(int grad)
        {
            return (grad - 32)/1.8;
        }
    }
}
