using System;
using Mentoring.Lab3.SymbolLibrary.Services.Interfaces;

namespace Mentoring.Lab3.SymbolLibrary.Services
{
    public class InputOutputService : IInputOutputService
    {
        public string GetRow()
        {
            return Console.ReadLine();
        }

        public void DisplayLine(string value)
        {
            Console.WriteLine(value);
        }

        public void Display(string value)
        {
            Console.Write(value);
        }
    }
}