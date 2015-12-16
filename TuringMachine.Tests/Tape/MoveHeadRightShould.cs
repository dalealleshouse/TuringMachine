using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TuringMachine.Tests.Tape
{
    [TestClass]
    public class MoveHeadRightShould
    {
        [TestMethod]
        public void ReturnNewTapeWhenRightIsEmpty()
        {
            const string expected = "Tape: 1011(_)";
            var sut = new TuringMachine.Tape(new[] {'1', '0', '1'}, '1', new char[0]);
            var result = sut.MoveHeadRight();
            Assert.AreEqual(expected, result.ToString());
        }

        [TestMethod]
        public void ReturnNewTapeWhenLeftIsEmpty()
        {
            const string expected = "Tape: 1(1)01";
            var sut = new TuringMachine.Tape(new char[0], '1', new[] { '1', '0', '1' });
            var result = sut.MoveHeadRight();
            Assert.AreEqual(expected, result.ToString());
        }

        [TestMethod]
        public void ReturnNewTape()
        {
            const string expected = "Tape: 1011(1)01";
            var sut = new TuringMachine.Tape(new[] { '1', '0', '1' }, '1', new[] { '1', '0', '1' });
            var result = sut.MoveHeadRight();
            Assert.AreEqual(expected, result.ToString());
        }
    }
}