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
                StreamReader streamReader = null;
                Console.WriteLine(nameof(FileOpenFinallyTest));
                try
                {
                    streamReader = File.OpenText("foo.txt");
                    Console.WriteLine(streamReader);
                }
                finally
                {
                    streamReader?.Dispose();
                }
                ////////////////////////////////
            });
        }

        [Test]
        public void FileOpenUsingStatementTest()
        {
            Assert.Throws<FileNotFoundException>(() =>
            {
                /////////////////////////////////
                Console.WriteLine(nameof(FileOpenUsingStatementTest));
                using (var streamReader = File.OpenText("foo.txt"))
                {
                    Console.WriteLine(streamReader);
                }
                ////////////////////////////////
            });
        }

        [Test]
        public void FileOpenUsingDeclarationTest()
        {
            Assert.Throws<FileNotFoundException>(() =>
            {
                /////////////////////////////////
                Console.WriteLine(nameof(FileOpenUsingDeclarationTest));
                using var streamReader = File.OpenText("foo.txt");
                Console.WriteLine(streamReader);
                ////////////////////////////////
            });
        }
    }
}
