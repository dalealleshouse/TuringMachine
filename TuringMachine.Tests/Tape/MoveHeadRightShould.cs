using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TuringMachine.Tests.Tape
{
    [TestClass]
    public class MoveHeadRightShould
    {
        [TestMethod]
        public void MoveRightWhenAtLastHeadPostion()
        {
            const string expected = "Tape: abcd(_)";
            var sut = new TuringMachine.Tape(new[] { 'a', 'b', 'c', 'd' }, 3);
            var result = sut.MoveHeadRight();
            Assert.AreEqual(expected, result.ToString());
        }

        [TestMethod]
        public void MoveToTheRight()
        {
            var data = new[] {'a', 'b', 'c', 'd', 'e'};

            var expected = "Tape: abcd(e)";
            var sut = new TuringMachine.Tape(data, 3);
            var result = sut.MoveHeadRight();
            Assert.AreEqual(expected, result.ToString());

            expected = "Tape: a(b)cde";
            sut = new TuringMachine.Tape(data, 0);
            result = sut.MoveHeadRight();
            Assert.AreEqual(expected, result.ToString());

            expected = "Tape: ab(c)de";
            sut = new TuringMachine.Tape(data, 1);
            result = sut.MoveHeadRight();
            Assert.AreEqual(expected, result.ToString());
        }
    }
}