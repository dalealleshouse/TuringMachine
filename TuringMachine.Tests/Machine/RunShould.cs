using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TuringMachine.Tests.Machine
{
    [TestClass]
    public class RunShould
    {
        [TestMethod]
        public void StepToEnd()
        {
            const string expected = "Tape: (_)1111__";
            var sut = new TuringMachine.Machine(
                0,
                new TuringMachine.Tape(new[] { '1', '1', TuringMachine.Tape.Blank, '1', '1' }, 0),
                TransitionTableGenerator.Addition());

            var result = sut.Run();
            Assert.AreEqual(expected, result.Tape.ToString());
        }

        [TestMethod]
        public void ReturnOnError()
        {
            const string expected = "Tape: (1)1_11";
            var sut = new TuringMachine.Machine(
                6,
                new TuringMachine.Tape(new[] { '1', '1', TuringMachine.Tape.Blank, '1', '1' }, 0),
                TransitionTableGenerator.Addition());

            var result = sut.Run();
            Assert.AreEqual(expected, result.Tape.ToString());
            Assert.AreEqual(State.Error, result.State);
        }
    }
}