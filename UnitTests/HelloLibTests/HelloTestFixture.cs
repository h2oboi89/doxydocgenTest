using HelloLib;
using NUnit.Framework;

namespace UnitTests.HelloLibTests
{
    [TestFixture]
    class HelloTestFixture
    {
        [Test]
        public void NameShouldDefaultToWorld()
        {
            Assert.That(new Hello().ToString(), Is.EqualTo("Hello, World!"));
        }

        [Test]
        public void SpecifiedNameShouldBeUsed()
        {
            Assert.That(new Hello("<INSERT TEST SUBJECT NAME HERE>").ToString(), Is.EqualTo("Hello, <INSERT TEST SUBJECT NAME HERE>!"));
        }
    }
}
