using LifeApi.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LifeApi.Tests.Helpers
{
    [TestClass]
    public class DateTimeHelperTests
    {
        [TestMethod]
        public void GenerateDateStamp_GivenValidDateTime_ReturnsStringInAppropriateFormat()
        {
            DateTime timeToConvert = new DateTime(2018,01,31);
            string expected = "01312018";
            var dateTimeHelper = new DateTimeHelper();

            string actual = dateTimeHelper.GenerateDateStamp(timeToConvert);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GenerateDateStamp_GivenMinValueInput_ReturnsEmptyString()
        {
            DateTime timeToConvert = DateTime.MinValue;
            string expected = String.Empty;
            var dateTimeHelper = new DateTimeHelper();

            string actual = dateTimeHelper.GenerateDateStamp(timeToConvert);

            Assert.AreEqual(expected, actual);
        }
    }
}