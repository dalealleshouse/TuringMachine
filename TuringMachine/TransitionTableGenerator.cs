using System.Collections.Generic;
using System.Resources;

namespace TuringMachine
{
    public static class TransitionTableGenerator
    {
        public static IEnumerable<Transition> Addition() => new[]
        {
            new Transition(0, Tape.Blank, Tape.Blank, HeadDirection.Right, 0),
            new Transition(0, '1', '1', HeadDirection.Right, 1),
            new Transition(1, Tape.Blank, '1', HeadDirection.Right, 2),
            new Transition(1, '1', '1', HeadDirection.Right, 1),
            new Transition(2, Tape.Blank, Tape.Blank, HeadDirection.Left, 3),
            new Transition(2, '1', '1', HeadDirection.Right, 2),
            new Transition(3, Tape.Blank, Tape.Blank, HeadDirection.Left, 3),
            new Transition(3, '1', Tape.Blank, HeadDirection.Left, 4),
            new Transition(4, Tape.Blank, Tape.Blank, HeadDirection.NoMove, State.Halt),
            new Transition(4, '1', '1', HeadDirection.Left, 4)
        };
    }
}