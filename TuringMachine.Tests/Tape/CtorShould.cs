using System;
using System.Collections.Generic;
using AssertExLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TuringMachine.Tests.Tape
{
    [TestClass]
    public class CtorShould
    {
        [TestMethod]
        public void ThrowIfHeadPostionIsInvalid()
        {
            AssertEx.Throws<IndexOutOfRangeException>(
                () => new TuringMachine.Tape(new[] {'a', 'b'}, 3));

            AssertEx.Throws<IndexOutOfRangeException>(
                () => new TuringMachine.Tape(new[] { 'a', 'b' }, -1));
        }
    }
}