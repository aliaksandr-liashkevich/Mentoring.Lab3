using System;
using Mentoring.Lab3.SymbolLibrary.Extensions;
using Mentoring.Lab3.SymbolLibrary.Services.Interfaces;

namespace Mentoring.Lab3.SymbolLibrary
{
    public static class Application
    {
        public const char RowEndSymbol = 'q';

        public static void Run(IInputOutputService inputOutputService)
        {
            var working = true;
            while (working)
            {
                inputOutputService.Display("Enter number: ");
                var row = inputOutputService.GetRow();

                try
                {
                    var firstSymbol = row.FirstSymbol();
                    if (firstSymbol == RowEndSymbol && row.Length == 1)
                        working = false;
                    else
                        inputOutputService.DisplayLine($"Result: {firstSymbol}.");
                }
                catch (ArgumentException argumentException)
                {
                    inputOutputService.DisplayLine($"Error: {argumentException.Message}");
                }
            }
        }
    }
}