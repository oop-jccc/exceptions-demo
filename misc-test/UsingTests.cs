using System;
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

                ////////////////////////////////
            });
        }

        [Test]
        public void FileOpenUsingStatementTest()
        {
            Assert.Throws<FileNotFoundException>(() =>
            {
                /////////////////////////////////
    
                ////////////////////////////////
            });
        }

        [Test]
        public void FileOpenUsingDeclarationTest()
        {
            Assert.Throws<FileNotFoundException>(() =>
            {
                /////////////////////////////////

                ////////////////////////////////
            });
        }
    }
}
