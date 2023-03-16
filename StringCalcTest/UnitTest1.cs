namespace StringCalcTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
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

        [TestMethod]
        public void ResultZero_When_StringIsEmpty()
        {
            double result = StringCalc.Add("");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ResultTheNumber_When_StringIsNumber()
        {
            double result = StringCalc.Add("1");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ResultTheNumber2_When_StringIsNumber()
        {
            string s = "12.5";
            double result = StringCalc.Add(s);
            Assert.AreEqual(12.5, result);
        }

        [TestMethod]
        public void ResultTheSum_When_StringHasTwoNumbers()
        {
            double result = StringCalc.Add("12 5   100");
            Assert.AreEqual(117, result);
        }

    }
}