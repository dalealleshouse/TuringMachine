using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TuringMachine.Tests.Tape
{
    [TestClass]
    public class MoveHeadLeftShould
    {
        [TestMethod]
        public void MoveLeftWhenAtZeroHeadPostion()
        {
            const string expected = "Tape: (_)abcd";
            var sut = new TuringMachine.Tape(new[] {'a', 'b', 'c', 'd'}, 0);
            var result = sut.MoveHeadLeft();
            Assert.AreEqual(expected, result.ToString());
        }

        [TestMethod]
        public void MoveToTheLeft()
        {
            var data = new[] {'a', 'b', 'c', 'd', 'e'};

            var expected = "Tape: ab(c)de";
            var sut = new TuringMachine.Tape(data, 3);
            var result = sut.MoveHeadLeft();
            Assert.AreEqual(expected, result.ToString());

            expected = "Tape: abc(d)e";
            sut = new TuringMachine.Tape(data, 4);
            result = sut.MoveHeadLeft();
            Assert.AreEqual(expected, result.ToString());

            expected = "Tape: (a)bcde";
            sut = new TuringMachine.Tape(data, 1);
            result = sut.MoveHeadLeft();
            Assert.AreEqual(expected, result.ToString());
        }
    }
}