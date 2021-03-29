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

        [Test]
        public void GivenStringOfNumbersReturnHighestAndLowestNumber()
        {
            Assert.AreEqual("42 -9", _codewars.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }

        [Test]
        public void GivenIntArrayOfPeoplesMoneyReturnIfAbleToGiveChangeToEveryone()
        {
            //int[] peopleInLine = new int[] { 25, 25, 50, 50 };
            //int[] peopleInLine2 = new int[] { 25, 100 };
            //int[] peopleInLine3 = new int[] { 25, 25, 50, 50, 25, 100 };
            int[] peopleInLine4 = new int[] { 25, 25, 50, 100 };

            //Assert.AreEqual("YES", _codewars.Tickets(peopleInLine));
            //Assert.AreEqual("NO", _codewars.Tickets(peopleInLine2));
            //Assert.AreEqual("YES", _codewars.Tickets(peopleInLine3));
            Assert.AreEqual("YES", _codewars.Tickets(peopleInLine4));
        }
    }
}