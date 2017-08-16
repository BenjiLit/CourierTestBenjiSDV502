using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastwayCourier;

namespace CourierTestBenji
{

    [TestClass]
    public class GetDestinationZoneColour_Should
    {

        [TestMethod]
        public void ReturnZoneColour_Pink()
        {
            //Arrange
            ParcelQuoteFromNelson lcQuoteFromNelson = new ParcelQuoteFromNelson();

            //Act
            string lcTicketColour = lcQuoteFromNelson.GetDestinationZone("Nelson"); //town name

            //Assert
            Assert.AreEqual("Pink", lcTicketColour); //ticket colour
        }

        [TestMethod]
        public void ReturnZoneColour_Blue()
        {
            //Arrange
            ParcelQuoteFromNelson lcQuoteFromNelson = new ParcelQuoteFromNelson();

            //Act
            string lcTicketColour = lcQuoteFromNelson.GetDestinationZone("Riwaka"); //town name

            //Assert
            Assert.AreEqual("Blue", lcTicketColour); //ticket colour
        }

        [TestMethod]
        public void ReturnZoneColour_Lime()
        {
            //Arrange
            ParcelQuoteFromNelson lcQuoteFromNelson = new ParcelQuoteFromNelson();

            //Act
            string lcTicketColour = lcQuoteFromNelson.GetDestinationZone("Nelson Lakes National Park"); //town name

            //Assert
            Assert.AreEqual("Lime", lcTicketColour); //ticket colour
        }

        [TestMethod]
        public void ReturnZoneColour_Orange()
        {
            //Arrange
            ParcelQuoteFromNelson lcQuoteFromNelson = new ParcelQuoteFromNelson();

            //Act
            string lcTicketColour = lcQuoteFromNelson.GetDestinationZone("Kaikoura"); //town name

            //Assert
            Assert.AreEqual("Orange", lcTicketColour); //ticket colour
        }
           
    }
}
