using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TuringMachine.Tests.Tape
{
    [TestClass]
    public class ReadShould
    {
        [TestMethod]
        public void ReturnTapeHead()
        {
            var data = new[] { 'a', 'b', 'c' };

            const char expected = 'b';
            var sut = new TuringMachine.Tape(data, 1);
            var result = sut.Read();
            Assert.AreEqual(expected, result);
        }
    }
}