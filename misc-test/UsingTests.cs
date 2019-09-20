using System.IO;
using NUnit.Framework;

namespace Tests
{
   public class UsingTests
    {
        [Test]
        public void FileOpenFinallyTest()
        {
            Assert.Throws<FileNotFoundException>(() =>
            {
                ///////////////////////////////
                StreamReader streamReader = null;
                try
                {
                    streamReader = File.OpenText("foo.txt");
                }
                finally
                {
                    streamReader?.Dispose();
                }
                ////////////////////////////////
            });
        }

        [Test]
        public void FileOpenUsingTest()
        {
            Assert.Throws<FileNotFoundException>(() =>
            {
                /////////////////////////////////
                using (var streamReader = File.OpenText("foo.txt"))
                {
                }
                ////////////////////////////////
            });
        }
    }
}