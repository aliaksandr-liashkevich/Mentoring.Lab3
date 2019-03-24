using System;
using System.Text.RegularExpressions;
using Mentoring.Lab3.NumberLibrary.Exceptions;
using Mentoring.Lab3.SymbolLibrary.Extensions;

namespace Mentoring.Lab3.NumberLibrary.Extensions
{
    public static class NumberExtension
    {
        public const char MinusSymbol = '-';

        public static string NumberPattern;

        static NumberExtension()
        {
            NumberPattern = $@"^{MinusSymbol}?\d+$";
        }

        public static int ToInt(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"{nameof(value)} must be set.");
            }

            if (!Regex.IsMatch(value, NumberPattern))
            {
                throw new ArgumentException($"{nameof(value)} must contain only digit.");
            }

            var isPositive = value.FirstSymbol() != MinusSymbol;

            var startIndex = value.Length - 1;
            var endIndex = isPositive ? 0 : 1;

            long power = 1;
            var number = 0;

            for (var i = startIndex; i >= endIndex; i--)
            {
                try
                {
                    checked
                    {
                        number += (int) ((value[i] - '0') * power);
                        power *= 10;
                    }
                }
                catch (OverflowException overflowException)
                {
                    throw new ParsingException($"{nameof(value)} is long number.", value, overflowException);
                }
            }

            if (isPositive)
            {
                return number;
            }

            return -number;
        }
    }
}
