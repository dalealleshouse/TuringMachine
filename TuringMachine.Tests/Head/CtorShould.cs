namespace TuringMachine.Tests.Head
{
    using System;

    using AssertExLib;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CtorShould
    {
        [TestMethod]
        public void ThrowIfHeadPostionIsInvalid()
        {
            AssertEx.Throws<IndexOutOfRangeException>(
                () => new TuringMachine.Head(new[] {'a', 'b'}, 3));

            AssertEx.Throws<IndexOutOfRangeException>(
                () => new TuringMachine.Head(new[] { 'a', 'b' }, -1));
        }
    }
}