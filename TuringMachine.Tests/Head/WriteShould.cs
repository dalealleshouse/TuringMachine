namespace TuringMachine.Tests.Head
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class WriteShould
    {
        [TestMethod]
        public void ReturnNewTapeWithUpdatedHead()
        {
            var data = new[] {'a', 'b', 'c'};

            const string expected = "Head: a(f)c";
            var sut = new TuringMachine.Head(data, 1);
            var result = sut.Write('f');
            Assert.AreEqual(expected, result.ToString());
        }

        [TestMethod]
        public void NotMutateOriginalData()
        {
            var data = new[] { 'a', 'b', 'c' };

            const string expected = "Head: a(b)c";
            var sut = new TuringMachine.Head(data, 1);
            sut.Write('f');
            Assert.AreEqual(expected, sut.ToString());
        }
    }
}