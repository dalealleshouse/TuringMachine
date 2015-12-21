namespace TuringMachine.Tests.Head
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MoveHeadLeftShould
    {
        [TestMethod]
        public void MoveLeftWhenAtZeroHeadPostion()
        {
            const string expected = "Tape: (_)abcd";
            var sut = new TuringMachine.Head(new[] {'a', 'b', 'c', 'd'}, 0);
            var result = sut.MoveLeft();
            Assert.AreEqual(expected, result.ToString());
        }

        [TestMethod]
        public void MoveToTheLeft()
        {
            var data = new[] {'a', 'b', 'c', 'd', 'e'};

            var expected = "Tape: ab(c)de";
            var sut = new TuringMachine.Head(data, 3);
            var result = sut.MoveLeft();
            Assert.AreEqual(expected, result.ToString());

            expected = "Tape: abc(d)e";
            sut = new TuringMachine.Head(data, 4);
            result = sut.MoveLeft();
            Assert.AreEqual(expected, result.ToString());

            expected = "Tape: (a)bcde";
            sut = new TuringMachine.Head(data, 1);
            result = sut.MoveLeft();
            Assert.AreEqual(expected, result.ToString());
        }
    }
}