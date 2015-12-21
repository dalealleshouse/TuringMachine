using System;
using System.Collections.Generic;
using System.Linq;

namespace TuringMachine
{
    public class Head
    {
        public const char Blank = '_';

        public Head(IEnumerable<char> tape, int headPosition)
        {
            if (tape == null) throw new ArgumentNullException(nameof(tape));

            var safeData = tape as char[] ?? tape.ToArray();
            if (headPosition > safeData.Count() - 1 || headPosition < 0)
                throw new IndexOutOfRangeException("Invalid head position");

            Tape = safeData;
            HeadPosition = headPosition;
        }

        public IEnumerable<char> Tape { get; }

        public int HeadPosition { get; }

        public Head Write(char head) => new Head(new List<char>(Tape) { [HeadPosition] = head }, HeadPosition);

        public Head MoveLeft() => HeadPosition == 0
            ? new Head(new[] { Blank }.Concat(Tape), 0)
            : new Head(Tape, HeadPosition - 1);

        public Head MoveRight() => HeadPosition == Tape.Count() - 1
            ? new Head(Tape.Concat(new[] { Blank }), HeadPosition + 1)
            : new Head(Tape, HeadPosition + 1);

        public Head Move(HeadDirection direction)
        {
            switch (direction)
            {
                case HeadDirection.Left:
                    return MoveLeft();
                case HeadDirection.NoMove:
                    return this;
                case HeadDirection.Right:
                    return MoveRight();
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
        }

        public char Read() => Tape.ElementAt(HeadPosition);

        public override string ToString() => $@"Tape: {Tape.Select(GetChar).Aggregate((agg, next) => agg + next)}";

        private string GetChar(char c, int index) => index == HeadPosition ? $"({c})" : c.ToString();
    }
}