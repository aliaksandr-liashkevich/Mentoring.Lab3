using System;
using Mentoring.Lab3.NumberLibrary.Exceptions;
using Mentoring.Lab3.NumberLibrary.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mentoring.Lab3.NumberLibrary.Tests.Extensions
{
    [TestClass]
    public class NumberExtensionTests
    {
        [TestMethod]
        [DataRow("123", 123)]
        [DataRow("-12", -12)]
        [DataRow("0001", 1)]
        [DataRow("-0001", -1)]
        [DataRow("-0", 0)]
        [DataRow("1233131", 1233131)]
        [DataRow("-77993", -77993)]
        public void ToInt(string number, int expected)
        {
            int actual = number.ToInt();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToInt_LongNumber_ParsingException()
        {
            var number = "1203912931293127897897828282";
            Assert.ThrowsException<ParsingException>(() => number.ToInt());
        }

        [TestMethod]
        [DataRow("-q0")]
        [DataRow("qwerty")]
        [DataRow("10O")]
        public void ToInt_NonDigitString_ArgumentException(string value)
        {
            var exception = Assert.ThrowsException<ArgumentException>(() => value.ToInt());
            Assert.AreEqual(exception.Message, $"{nameof(value)} must contain only digit.");
        }
    }
}
