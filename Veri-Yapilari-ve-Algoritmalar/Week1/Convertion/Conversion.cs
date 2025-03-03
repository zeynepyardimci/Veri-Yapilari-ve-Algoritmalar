namespace ConversionLib
{
    public class Conversion
    {
        public int ToUNumber(string bit)
        {

            int len = bit.Length;
            // 2^7 + 2^6 + 2^5 + 2^4 + 2^3 + 2^2 + 2^1+ 2^0
            int agg = 0;
            for (int i = len; i > 0; i--)
            {
                agg += int.Parse(bit[i - 1].ToString()) * (int)Math.Pow(2, len - i);
            }
            return agg;
        }

        public int ToNumber(string bit)
        {
            // -2^7 + 2^6 + 2^5 + 2^4 + 2^3 + 2^2 + 2^1+ 2^0
            int agg = 0;

            if (bit[0] == '1')
            {
                agg += -1 * (int)Math.Pow(2, bit.Length - 1);
            }
            int len = bit.Length;
            for (int i = len; i > 1; i--)
            {
                agg += int.Parse(bit[i - 1].ToString()) * (int)Math.Pow(2, len - i);
            }
            return agg;
        }
    }
}
