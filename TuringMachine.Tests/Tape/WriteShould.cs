using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TuringMachine.Tests.Tape
{
    [TestClass]
    public class WriteShould
    {
        [TestMethod]
        public void ReturnNewTapeWithUpdatedHead()
        {
            var data = new[] {'a', 'b', 'c'};

            const string expected = "Tape: a(f)c";
            var sut = new TuringMachine.Tape(data, 1);
            var result = sut.Write('f');
            Assert.AreEqual(expected, result.ToString());
        }

        [TestMethod]
        public void NotMutateOriginalData()
        {
            var data = new[] { 'a', 'b', 'c' };

            const string expected = "Tape: a(b)c";
            var sut = new TuringMachine.Tape(data, 1);
            sut.Write('f');
            Assert.AreEqual(expected, sut.ToString());
        }
    }
}