using System.Collections.Generic;

namespace TuringMachine
{
    public static class TransitionTableGenerator
    {
        public static IEnumerable<Transition> Addition() => new[]
        {
            new Transition(0, Head.Blank, Head.Blank, HeadDirection.Right, 0),
            new Transition(0, '1', '1', HeadDirection.Right, 1),
            new Transition(1, Head.Blank, '1', HeadDirection.Right, 2),
            new Transition(1, '1', '1', HeadDirection.Right, 1),
            new Transition(2, Head.Blank, Head.Blank, HeadDirection.Left, 3),
            new Transition(2, '1', '1', HeadDirection.Right, 2),
            new Transition(3, Head.Blank, Head.Blank, HeadDirection.Left, 3),
            new Transition(3, '1', Head.Blank, HeadDirection.Left, 4),
            new Transition(4, Head.Blank, Head.Blank, HeadDirection.NoMove, State.Halt),
            new Transition(4, '1', '1', HeadDirection.Left, 4)
        };

        public static IEnumerable<Transition> Multiplication() => new[]
        {
            new Transition(0, Head.Blank, Head.Blank, HeadDirection.Right, 1),
            new Transition(0, '1', Head.Blank, HeadDirection.Right, 2),
            new Transition(1, Head.Blank, Head.Blank, HeadDirection.Right, 14),
            new Transition(1, '1', Head.Blank, HeadDirection.Right, 2),
            new Transition(2, Head.Blank, Head.Blank, HeadDirection.Right, 3),
            new Transition(2, '1', '1', HeadDirection.Right, 2),
            new Transition(3, Head.Blank, Head.Blank, HeadDirection.Left, 15),
            new Transition(3, '1', Head.Blank, HeadDirection.Right, 4),
            new Transition(4, Head.Blank, Head.Blank, HeadDirection.Right, 5),
            new Transition(4, '1', '1', HeadDirection.Right, 4),
            new Transition(5, Head.Blank, '1', HeadDirection.Left, 6),
            new Transition(5, '1', '1', HeadDirection.Right, 5),
            new Transition(6, Head.Blank, Head.Blank, HeadDirection.Left, 7),
            new Transition(6, '1', '1', HeadDirection.Left, 6),
            new Transition(7, Head.Blank, '1', HeadDirection.Left, 9),
            new Transition(7, '1', '1', HeadDirection.Left, 8),
            new Transition(8, Head.Blank, '1', HeadDirection.Right, 3),
            new Transition(8, '1', '1', HeadDirection.Left, 8),
            new Transition(9, Head.Blank, Head.Blank, HeadDirection.Left, 10),
            new Transition(9, '1', '1', HeadDirection.Left, 9),
            new Transition(10, Head.Blank, Head.Blank, HeadDirection.Right, 12),
            new Transition(10, '1', '1', HeadDirection.Left, 11),
            new Transition(11, Head.Blank, Head.Blank, HeadDirection.Right, 0),
            new Transition(11, '1', '1', HeadDirection.Left, 11),
            new Transition(12, Head.Blank, Head.Blank, HeadDirection.Right, 12),
            new Transition(12, '1', Head.Blank, HeadDirection.Right, 13),
            new Transition(13, Head.Blank, Head.Blank, HeadDirection.NoMove, State.Halt),
            new Transition(13, '1', Head.Blank, HeadDirection.Right, 13),
            new Transition(14, Head.Blank, Head.Blank, HeadDirection.NoMove, State.Halt),
            new Transition(14, '1', Head.Blank, HeadDirection.Right, 14),
            new Transition(15, Head.Blank, Head.Blank, HeadDirection.Left, 16),
            new Transition(15, '1', Head.Blank, HeadDirection.Left, 15),
            new Transition(16, Head.Blank, Head.Blank, HeadDirection.NoMove, State.Halt),
            new Transition(16, '1', Head.Blank, HeadDirection.Left, 16)

        };
    }
}