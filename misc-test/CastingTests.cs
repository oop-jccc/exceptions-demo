using System;
using NUnit.Framework;

namespace Tests
{
    class Parent {}

    class Foo :Parent {}

    class Bar : Parent {}

    public class CastingTests
    {
        [Test]
        public void InvalidCastTest()
        {
            Assert.Throws<InvalidCastException>(() =>
            {
                Parent foo = new Foo();
                var bar = (Bar) foo;
            });
        }

        [Test]
        public void IsOperatorTest()
        {
            Parent foo = new Foo();
            Assert.IsFalse(foo is Bar);
        }

        [Test]
        public void AsOperatorTest()
        {
            Parent foo = new Foo();
            Assert.IsNull(foo as Bar);
        }
    }
}