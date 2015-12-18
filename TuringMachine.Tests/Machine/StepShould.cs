using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TuringMachine.Tests.Machine
{
    [TestClass]
    public class StepShould
    {
        [TestMethod]
        public void GoIntoErrorStateIfNoMatchingTransitions()
        {
            var sut = new TuringMachine.Machine(
                6,
                new TuringMachine.Tape(new[] {'1', '1', '1'}, 1),
                TransitionTableGenerator.Addition());

            var result = sut.Step();
            Assert.AreEqual(State.Error, result.State);
        }

        [TestMethod]
        public void ReturnThisIfHalted()
        {
            var sut = new TuringMachine.Machine(
                State.Halt,
                new TuringMachine.Tape(new[] {'1', '1', '1'}, 0),
                TransitionTableGenerator.Addition());

            var result = sut.Step();
            Assert.AreEqual(State.Halt, result.State);
        }

        [TestMethod]
        public void ReturnThisIfError()
        {
            var sut = new TuringMachine.Machine(
                State.Error,
                new TuringMachine.Tape(new[] {'1', '1', '1'}, 0),
                TransitionTableGenerator.Addition());

            var result = sut.Step();
            Assert.AreEqual(State.Error, result.State);
        }

        [TestMethod]
        public void MakeTransition()
        {
            var sut = new TuringMachine.Machine(
                0,
                new TuringMachine.Tape(new[] {'1', '1', '1', TuringMachine.Tape.Blank, '1', '1'}, 0),
                TransitionTableGenerator.Addition());

            var result = sut.Step();
            Assert.AreEqual(1, result.State);
            Assert.AreEqual('1', result.Tape.Read());
        }

        [TestMethod]
        public void WriteTransition()
        {
            var sut = new TuringMachine.Machine(
                3,
                new TuringMachine.Tape(new[] { '1', '1', '1' }, 1),
                TransitionTableGenerator.Addition());
            
            var result = sut.Step().Tape.MoveHeadRight().Read();
            Assert.AreEqual(TuringMachine.Tape.Blank, result);
        }
    }
}