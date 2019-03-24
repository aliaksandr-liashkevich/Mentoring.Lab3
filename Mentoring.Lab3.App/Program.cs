using System;
using Mentoring.Lab3.SymbolLibrary.Services;
using NumberApplication = Mentoring.Lab3.NumberLibrary.Application;
using SymbolApplication = Mentoring.Lab3.SymbolLibrary.Application;

namespace Mentoring.Lab3.App
{
    class Program
    {
        private static void Main(string[] args)
        {
            var inputOutputService = new InputOutputService();
            NumberApplication.Run(inputOutputService);
            //SymbolApplication.Run(inputOutputService);
        }
    }
}
