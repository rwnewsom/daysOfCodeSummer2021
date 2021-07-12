using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaysOfCode.Tests
{
    [TestClass]
    public class GreenTicketTests
    {
        [TestMethod]
        public void FiveSixSevenShouldReturnZero()
        {
            GreenTicket greenTicket = new GreenTicket();
            int result = greenTicket.ticketValue(5, 6, 7);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void FiveSixFiveShouldReturnTen()
        {
            GreenTicket greenTicket = new GreenTicket();
            int result = greenTicket.ticketValue(5, 6, 5);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void FiveFiveFiveShouldReturnTwenty()
        {
            GreenTicket greenTicket = new GreenTicket();
            int result = greenTicket.ticketValue(5, 5, 5);
            Assert.AreEqual(20, result);
        }

    }
}
