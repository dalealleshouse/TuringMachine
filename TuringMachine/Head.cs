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
                throw new IndexOutOfRangeException("Invalid head postion");

            this.Tape = safeData;
            this.HeadPosition = headPosition;
        }

        public IEnumerable<char> Tape { get; }

        public int HeadPosition { get; }

        public Head Write(char head) => new Head(new List<char>(this.Tape) { [this.HeadPosition] = head }, this.HeadPosition);

        public Head MoveLeft() => this.HeadPosition == 0
            ? new Head(new[] { Blank }.Concat(this.Tape), 0)
            : new Head(this.Tape, this.HeadPosition - 1);

        public Head MoveRight() => this.HeadPosition == this.Tape.Count() - 1
            ? new Head(this.Tape.Concat(new[] { Blank }), this.HeadPosition + 1)
            : new Head(this.Tape, this.HeadPosition + 1);

        public Head Move(HeadDirection direction)
        {
            switch (direction)
            {
                case HeadDirection.Left:
                    return this.MoveLeft();
                case HeadDirection.NoMove:
                    return this;
                case HeadDirection.Right:
                    return this.MoveRight();
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
        }

        public char Read() => this.Tape.ElementAt(this.HeadPosition);

        public override string ToString() => $@"Tape: {this.Tape.Select(GetChar).Aggregate((agg, next) => agg + next)}";

        private string GetChar(char c, int index) => index == this.HeadPosition ? $"({c})" : c.ToString();
    }
}