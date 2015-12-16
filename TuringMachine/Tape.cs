using System;
using System.Collections.Generic;
using System.Linq;

namespace TuringMachine
{
    public class Tape
    {
        public static readonly char Blank = '_';

        public Tape(IEnumerable<char> left, char head, IEnumerable<char> right)
        {
            if (left == null) throw new ArgumentNullException(nameof(left));
            if (right == null) throw new ArgumentNullException(nameof(right));

            Left = left;
            Head = head;
            Right = right;
        }

        public IEnumerable<char> Left { get; }

        public char Head { get; }

        public IEnumerable<char> Right { get; }

        public Tape Write(char head) => new Tape(Left, head, Right);

        public Tape MoveHeadLeft()
        {
            var left = Left.Take(Left.Count() - 1);
            var head = Left.DefaultIfEmpty(Blank).Last();
            var right = new [] {Head}.Concat(Right);

            return new Tape(left, head, right);
        }

        public Tape MoveHeadRight()
        {
            var left = Left.Concat(new [] {Head});
            var head = Right.DefaultIfEmpty(Blank).Last();
            var right = Right.Skip(1);

            return new Tape(left, head, right);
        }

        public override string ToString()
        {
            return $"Tape: {new string(Left.ToArray())}({Head}){new string(Right.ToArray())}";
        }
    }
}