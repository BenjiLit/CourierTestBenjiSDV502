using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastwayCourier;

namespace CourierTestBenji
{

    [TestClass]
    public class GetTicketPriceFromNelson_Should
    {

        [TestMethod]
        public void ReturnTicketPrice_ToPinkZone()
        {
            //Arrange
            ParcelQuoteFromNelson lcQuoteFromNelson = new ParcelQuoteFromNelson();

            //Act
            ParcelQuoteResult lcQuoteResult = lcQuoteFromNelson.CalculateQuote(12, "Pink"); //weight, destination zone

            //Assert
            Assert.AreEqual(0, lcQuoteResult.ExcessTickets); //excess tickets
            Assert.AreEqual(4.15m, lcQuoteResult.Price); //total price
        }

        [TestMethod]
        public void ReturnTicketPrice_ToBlueZone()
        {
            //Arrange
            ParcelQuoteFromNelson lcQuoteFromNelson = new ParcelQuoteFromNelson();

            //Act
            ParcelQuoteResult lcQuoteResult = lcQuoteFromNelson.CalculateQuote(12, "Blue"); //weight, destination zone

            //Assert
            Assert.AreEqual(0, lcQuoteResult.ExcessTickets); //excess tickets
            Assert.AreEqual(6.95m, lcQuoteResult.Price); //total price
        }

        [TestMethod]
        public void ReturnTicketPrice_ToLimeZone()
        {
            //Arrange
            ParcelQuoteFromNelson lcQuoteFromNelson = new ParcelQuoteFromNelson();

            //Act
            ParcelQuoteResult lcQuoteResult = lcQuoteFromNelson.CalculateQuote(12, "Lime"); //weight, destination zone

            //Assert
            Assert.AreEqual(0, lcQuoteResult.ExcessTickets); //excess tickets
            Assert.AreEqual(8.70m, lcQuoteResult.Price); //total price
        }

        [TestMethod]
        public void ReturnTicketPrice_ToOrangeZone()
        {
            //Arrange
            ParcelQuoteFromNelson lcQuoteFromNelson = new ParcelQuoteFromNelson();

            //Act
            ParcelQuoteResult lcQuoteResult = lcQuoteFromNelson.CalculateQuote(12, "Orange"); //weight, destination zone

            //Assert
            Assert.AreEqual(0, lcQuoteResult.ExcessTickets); //excess tickets
            Assert.AreEqual(12.95m, lcQuoteResult.Price); //total price
        }




    }
}
