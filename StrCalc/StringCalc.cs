namespace StringCalcTest
{
    public class StringCalc
    {
        public static double Add(string? s)
        {
            if (s == null) throw new NullReferenceException();
            if (s.Length == 0) return 0;

            string[] numbers = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            foreach (string number in numbers) { sum += double.Parse(number); }
            return sum;
        }
    }
}