using System;

namespace Mentoring.Lab3.SymbolLibrary.Extensions
{
    public static class SymbolExtension
    {
        public static char FirstSymbol(this string row)
        {
            if (string.IsNullOrEmpty(row))
            {
                throw new ArgumentException($"{nameof(row)} must be set.");
            }

            return row[0];
        }
    }
}
