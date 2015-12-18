using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TuringMachine.Tests.Tape
{
    [TestClass]
    public class MoveHeadShould
    {
        private static readonly IEnumerable<char> Data = new[] {'a', 'b', 'c', 'd', 'e'};

        public void MoveHeadLeftWithLeftDirection()
        {
            const string expected = "Tape: ab(c)de";
            var sut = new TuringMachine.Tape(Data, 3);
            var result = sut.MoveHead(HeadDirection.Left);
            Assert.AreEqual(expected, result.ToString());
        }

        public void MoveHeadRightWithRightDirection()
        {
            const string expected = "Tape: ab(c)de";
            var sut = new TuringMachine.Tape(Data, 1);
            var result = sut.MoveHead(HeadDirection.Right);
            Assert.AreEqual(expected, result.ToString());
        }

        public void NotMoveWithNoMove()
        {
            const string expected = "Tape: ab(c)de";
            var sut = new TuringMachine.Tape(Data, 2);
            var result = sut.MoveHead(HeadDirection.NoMove);
            Assert.AreEqual(expected, result.ToString());
        }
    }
}