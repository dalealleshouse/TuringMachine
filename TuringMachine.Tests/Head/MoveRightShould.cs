namespace TuringMachine.Tests.Head
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MoveHeadRightShould
    {
        [TestMethod]
        public void MoveRightWhenAtLastHeadPostion()
        {
            const string expected = "Tape: abcd(_)";
            var sut = new TuringMachine.Head(new[] { 'a', 'b', 'c', 'd' }, 3);
            var result = sut.MoveRight();
            Assert.AreEqual(expected, result.ToString());
        }

        [TestMethod]
        public void MoveToTheRight()
        {
            var data = new[] {'a', 'b', 'c', 'd', 'e'};

            var expected = "Tape: abcd(e)";
            var sut = new TuringMachine.Head(data, 3);
            var result = sut.MoveRight();
            Assert.AreEqual(expected, result.ToString());

            expected = "Tape: a(b)cde";
            sut = new TuringMachine.Head(data, 0);
            result = sut.MoveRight();
            Assert.AreEqual(expected, result.ToString());

            expected = "Tape: ab(c)de";
            sut = new TuringMachine.Head(data, 1);
            result = sut.MoveRight();
            Assert.AreEqual(expected, result.ToString());
        }
    }
}