using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace Codewars.Tests
{
    public class Tests
    {
        private Codewars _codewars;

        [SetUp]
        public void Setup()
        {
            _codewars = new Codewars();
        }

        [Test]
        public void ReturnLongestSorted()
        {
            Assert.AreEqual("aehrsty", _codewars.Longest("aretheyhere", "yestheyarehere"));
            Assert.AreEqual("abcdefghilnoprstu", _codewars.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
            Assert.AreEqual("acefghilmnoprstuy", _codewars.Longest("inmanylanguages", "theresapairoffunctions"));
        }
    }
}