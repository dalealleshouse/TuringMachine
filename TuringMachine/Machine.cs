using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace TuringMachine
{
    public class Machine
    {
        public Machine(int state, Tape tape, IEnumerable<Transition> transitionTable)
        {
            if (tape == null) throw new ArgumentNullException(nameof(tape));
            if (transitionTable == null) throw new ArgumentNullException(nameof(transitionTable));

            State = state;
            Tape = tape;
            TransitionTable = transitionTable;
        }

        public int State { get; }

        public Tape Tape { get; }

        public IEnumerable<Transition> TransitionTable { get; }

        public Machine Step()
        {
            if (State < 0) return this;

            return
                TransitionTable
                    .Where(t => t.InitialState == State && t.Read == Tape.Read())
                    .DefaultIfEmpty(new Transition(0, Tape.Blank, Tape.Read(), HeadDirection.NoMove,
                        TuringMachine.State.Error))
                    .Select(
                        t => new Machine(t.NextState, Tape.Write(t.Write).MoveHead(t.HeadDirection), TransitionTable))
                    .First();
        }

        public Machine Run()
        {
            var m = this;

            while (m.State >= 0)
                m = m.Step();

            return m;
        }
    }
}