using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TryParseExamples
{
    [TestClass]
    public class TryParseTests
    {
        [TestMethod]
        public void TryParseDoubleSuccessTest()
        {
            const string value = "3.14129";
            var success = double.TryParse(value, out var result);

            Assert.IsTrue(success);
            Assert.AreEqual(3.14129, result, 0.000001);
        }

        [TestMethod]
        public void TryParseDoubleFailTest()
        {
            const string value = "abcd";
            var success = double.TryParse(value, out var result);

            Assert.IsFalse(success);
            Assert.AreEqual(0, result);
        }
    }
}