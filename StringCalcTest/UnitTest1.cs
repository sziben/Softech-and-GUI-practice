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
    }
}