using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TuringMachine.Tests.Tape
{
    [TestClass]
    public class WriteShould
    {
        [TestMethod]
        public void ReturnNewTapeWithUpdatedHead()
        {
            var left = new[] {'a'};
            var right = new[] {'c'};
            const char head = 'b';

            const string expected = "Tape: a(b)c";
            var sut = new TuringMachine.Tape(left, 'f', right);
            var result = sut.Write(head);
            Assert.AreEqual(expected, result.ToString());
        }
    }
}