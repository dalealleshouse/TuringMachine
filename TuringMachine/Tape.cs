 using System;
using System.Collections.Generic;
using System.Linq;

namespace TuringMachine
{
    public class Tape
    {
        public static readonly char Blank = '_';

        public Tape(IEnumerable<char> data, int headPostion)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            var safeData = data as char[] ?? data.ToArray();
            if (headPostion > safeData.Count() - 1 || headPostion < 0)
                throw new IndexOutOfRangeException("Invalid head postion");

            Data = safeData;
            HeadPostion = headPostion;
        }

        public IEnumerable<char> Data { get; }

        public int HeadPostion { get; }

        public Tape Write(char head) => new Tape(new List<char>(Data) {[HeadPostion] = head}, HeadPostion);

        public Tape MoveHeadLeft() => HeadPostion == 0
            ? new Tape(new[] {Blank}.Concat(Data), 0)
            : new Tape(Data, HeadPostion - 1);

        public Tape MoveHeadRight() => HeadPostion == Data.Count() - 1
            ? new Tape(Data.Concat(new[] {Blank}), HeadPostion + 1)
            : new Tape(Data, HeadPostion + 1);

        public Tape MoveHead(HeadDirection direction)
        {
            switch (direction)
            {
                case HeadDirection.Left:
                    return MoveHeadLeft();
                case HeadDirection.NoMove:
                    return this;
                case HeadDirection.Right:
                    return MoveHeadRight();
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
        }

        public char Read() => Data.ElementAt(HeadPostion);

        public override string ToString() => $@"Tape: {Data.Select(GetChar).Aggregate((agg, next) => agg + next)}";

        private string GetChar(char c, int index) => index == HeadPostion ? $"({c})" : c.ToString();
    }
}