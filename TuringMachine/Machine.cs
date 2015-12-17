using System;
using System.Collections.Generic;

namespace TuringMachine
{
    public class Machine
    {
        private int _state;

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
            // find transition from table where state = currentstate and tapehead = tapehead
            // write to tapehead
            // move tapehead
            // change current state
            return null;
        }

        public Machine Run()
        {
            return null;
        }
    }
}