using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TryParseExamples
{
    [TestClass]
    public class DivideByZeroNoExceptionHandlingTests
    {
        [TestMethod]
        public void DivideByZeroNoExceptionHandlingTest()
        {
            var success = true;
            var numerator = 5;
            var denominator = 0;

            try
            {
                _ = numerator / denominator;
            }
            catch (DivideByZeroException e)
            {
                success = false;
            }
            finally
            {
                Assert.IsFalse(success);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroUnhandledExceptionHandlingTest()
        {
            var numerator = 5;
            var denominator = 0;
            _ = numerator / denominator;
        }
    }
}