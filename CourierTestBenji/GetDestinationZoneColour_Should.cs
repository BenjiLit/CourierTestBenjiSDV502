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
            string lcTicketColour = lcQuoteFromNelson.GetDestinationZone("Ward"); //town name

            //Assert
            Assert.AreEqual("Blue", lcTicketColour); //ticket colour
        }

        [TestMethod]
        public void ReturnZoneColour_Lime()
        {
            //Arrange
            ParcelQuoteFromNelson lcQuoteFromNelson = new ParcelQuoteFromNelson();

            //Act
            string lcTicketColour = lcQuoteFromNelson.GetDestinationZone("Murchison"); //town name

            //Assert
            Assert.AreEqual("Lime", lcTicketColour); //ticket colour
        }

        [TestMethod]
        public void ReturnZoneColour_Orange()
        {
            //Arrange
            ParcelQuoteFromNelson lcQuoteFromNelson = new ParcelQuoteFromNelson();

            //Act
            string lcTicketColour = lcQuoteFromNelson.GetDestinationZone("Reefton"); //town name

            //Assert
            Assert.AreEqual("Orange", lcTicketColour); //ticket colour
        }

             

        //-----------------------------



        [TestMethod]

        public void OtherTest()
        {
            ParcelQuoteFromNelson lcQuoteFromNelson = new ParcelQuoteFromNelson();
            string[] lcPinkTowns = new string[] { "Nelson", "Picton", "Hope" };

            foreach (string lcTowns in lcPinkTowns)
            {
                string lcTicketColour = lcQuoteFromNelson.GetDestinationZone(lcTowns); //town name
                Assert.AreEqual("Pink", lcTicketColour); //Ticket colour                             
            }            
        }
                

    }
}
