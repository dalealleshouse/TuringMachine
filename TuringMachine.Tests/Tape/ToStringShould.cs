using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TuringMachine.Tests.Tape
{
    [TestClass]
    public class ToStringShould
    {
        [TestMethod]
        public void PrintOutTape()
        {
            const string expected = "Tape: abc(d)cba";
            var sut = new TuringMachine.Tape(new[] {'a', 'b', 'c'}, 'd', new[] {'c', 'b', 'a'});
            Assert.AreEqual(expected, sut.ToString());
        }

        [TestMethod]
        public void PrintOutTapeWhenLeftIsEmpty()
        {
            const string expected = "Tape: (d)cba";
            var sut = new TuringMachine.Tape(new char[0], 'd', new[] {'c', 'b', 'a'});
            Assert.AreEqual(expected, sut.ToString());
        }

        [TestMethod]
        public void PrintOutTapeWhenRightIsEmpty()
        {
            const string expected = "Tape: abc(d)";
            var sut = new TuringMachine.Tape(new[] {'a', 'b', 'c'}, 'd', new char[0]);
            Assert.AreEqual(expected, sut.ToString());
        }
    }
}