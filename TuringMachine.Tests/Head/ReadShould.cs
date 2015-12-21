namespace TuringMachine.Tests.Head
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ReadShould
    {
        [TestMethod]
        public void ReturnTapeHead()
        {
            var data = new[] { 'a', 'b', 'c' };

            const char expected = 'b';
            var sut = new TuringMachine.Head(data, 1);
            var result = sut.Read();
            Assert.AreEqual(expected, result);
        }
    }
}