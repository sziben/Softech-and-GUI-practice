namespace StringCalcTest
{
    internal class StringCalc
    {
        internal static double Add(string? s)
        {
            if (s == null)
            {
                throw new NullReferenceException();
            }

            return double.Parse(s);
            
        }
    }
}