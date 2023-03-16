namespace StringCalcTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException (typeof (NullReferenceException))]
        public void ThrowsNullReferenceException_When_StringIsNull()
        {
            string s = null;
            double result = StringCalc.Add(s);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ThrowsFormatException_When_StringIsLetter()
        {
            double result = StringCalc.Add("A");
        }
    }
}