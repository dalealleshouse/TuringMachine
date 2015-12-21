namespace TuringMachine.Tests.Head
{
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MoveHeadShould
    {
        private static readonly IEnumerable<char> Data = new[] { 'a', 'b', 'c', 'd', 'e' };

        [TestMethod]
        public void MoveHeadLeftWithLeftDirection()
        {
            const string expected = "Tape: ab(c)de";
            var sut = new TuringMachine.Head(Data, 3);
            var result = sut.Move(HeadDirection.Left);
            Assert.AreEqual(expected, result.ToString());
        }

        [TestMethod]
        public void MoveHeadRightWithRightDirection()
        {
            const string expected = "Tape: ab(c)de";
            var sut = new TuringMachine.Head(Data, 1);
            var result = sut.Move(HeadDirection.Right);
            Assert.AreEqual(expected, result.ToString());
        }

        [TestMethod]
        public void NotMoveWithNoMove()
        {
            const string expected = "Tape: ab(c)de";
            var sut = new TuringMachine.Head(Data, 2);
            var result = sut.Move(HeadDirection.NoMove);
            Assert.AreEqual(expected, result.ToString());
        }
    }
}