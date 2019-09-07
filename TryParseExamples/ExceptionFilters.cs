using System;
using System.Net;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TryParseExamples
{
    [TestClass]
    public class ExceptionFilterTests
    {
        [TestMethod]
        public void ExceptionFilterTest() 
        {
            string result = null;
            try
            {
                new WebClient().DownloadString("https://google.com/");
            }
            catch (WebException ex) when (ex.Status == WebExceptionStatus.Timeout)
            {
                result = "Timeout!";
            }
            catch (WebException ex) when (ex.Status == WebExceptionStatus.NameResolutionFailure)
            {
                result = "Name resolution failure!";
            }
            catch (WebException ex)
            {
                result = $"Some other failure: {ex.Status}";
            }

            Assert.IsNull(result);
        }

    }
}