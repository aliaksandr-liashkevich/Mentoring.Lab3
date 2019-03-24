using System;
using Mentoring.Lab3.NumberLibrary.Exceptions;
using Mentoring.Lab3.NumberLibrary.Extensions;
using Mentoring.Lab3.SymbolLibrary.Extensions;
using Mentoring.Lab3.SymbolLibrary.Services.Interfaces;

namespace Mentoring.Lab3.NumberLibrary
{
    public static class Application
    {
        public const char RowEndSymbol = 'q';

        public static void Run(IInputOutputService inputOutputService)
        {
            var working = true;
            while (working)
            {
                inputOutputService.Display("Enter row: ");
                var row = inputOutputService.GetRow();

                try
                {
                    var number = row.ToInt();
                    if (row.FirstSymbol() == RowEndSymbol && row.Length == 1)
                        working = false;
                    else
                        inputOutputService.DisplayLine($"Result: {number}.");
                }
                catch (ArgumentException argumentException)
                {
                    inputOutputService.DisplayLine($"Error: {argumentException.Message}");
                }
                catch (ParsingException parsingException)
                {
                    inputOutputService.DisplayLine($"Error: {parsingException.Message}");
                }
            }
        }
    }
}
