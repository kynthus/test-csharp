using HtnHello;
using NUnit.Framework;

namespace HtnHelloTest
{
    public class HelloWorldTest
    {
        [Test]
        public void ResultOfGreet()
        {
            HelloWorld hw = new HelloWorld();
            Assert.AreEqual(hw.greet(), "Hello, World!");
        }
    }
}
