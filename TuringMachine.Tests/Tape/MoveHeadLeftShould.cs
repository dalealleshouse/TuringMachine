using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TuringMachine.Tests.Tape
{
    [TestClass]
    public class MoveHeadLeftShould
    {
        [TestMethod]
        public void ReturnNewTapeWhenRightIsEmpty()
        {
            const string expected = "Tape: 10(1)1";
            var sut = new TuringMachine.Tape(new[] {'1', '0', '1'}, '1', new char[0]);
            var result = sut.MoveHeadLeft();
            Assert.AreEqual(expected, result.ToString());
        }

        [TestMethod]
        public void ReturnNewTapeWhenLeftIsEmpty()
        {
            const string expected = "Tape: (_)1101";
            var sut = new TuringMachine.Tape(new char[0], '1', new[] { '1', '0', '1' });
            var result = sut.MoveHeadLeft();
            Assert.AreEqual(expected, result.ToString());
        }

        [TestMethod]
        public void ReturnNewTape()
        {
            const string expected = "Tape: 10(1)1101";
            var sut = new TuringMachine.Tape(new[] { '1', '0', '1' }, '1', new[] { '1', '0', '1' });
            var result = sut.MoveHeadLeft();
            Assert.AreEqual(expected, result.ToString());
        }
    }
}