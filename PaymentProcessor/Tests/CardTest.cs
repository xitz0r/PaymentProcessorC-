using NHibernate;
using NUnit.Framework;
using PaymentProcessor.Entities;
using PaymentProcessor.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor.Tests
{
    [TestFixture]
    public class CardTest
    {
        [OneTimeSetUp]
        public void PreparingTests()
        {
        }

        [Test]
        public void CantAcceptEmptyTrackData()
        {
            string trackData = "";
            int cvv2 = 123;

            Assert.Throws<Exception>(() => new Card(trackData, cvv2));
        }

        [Test]
        public void CantAcceptDifferentPANsInTracks()
        {
            string trackData = "%b44444444444444444^you/a gift for^23101211000000220000000?\r;55555555555555555=231012110000220?\r;04144?";

            Assert.Throws<Exception>(() => new Card(trackData, 0));
        }

        [Test]
        public void CantAcceptDifferentDatesInTracks()
        {
            string trackData = "%b44444444444444444^you/a gift for^23101211000000220000000?\r;b44444444444444444=231012110000220?\r;04144?";

            Assert.Throws<Exception>(() => new Card(trackData, 0));
        }

        [Test]
        public void CantAcceptPANWithLetters()
        {
            string trackData = "%B4ç444444444444444=210712110000220";

            Assert.Throws<Exception>(() => new Card(trackData, 0));
        }

        [Test]
        public void MustAcceptValidDate()   //this was due a bad implementation of CheckAndFillTracks, as it was putting the card's expiration date day as 31, and not all months have 31 days
        {
            string trackData = "%b44444444444444444^you/a gift for^23091211000000220000000?\r;44444444444444444=230912110000220?\r;04144?";

            Assert.DoesNotThrow(() => new Card(trackData, 0));
        }

        [Test]
        public void MustAcceptOnlyTrack1()
        {
            string trackData = "%b44444444444444444^you/a gift for^23101211000000220000000?";

            Assert.DoesNotThrow(() => new Card(trackData, 0));
        }

        [Test]
        public void MustAcceptOnlyTrack2()
        {
            string trackData = ";44444444444444444=231012110000220?";

            Assert.DoesNotThrow(() => new Card(trackData, 0));
        }

        [OneTimeTearDown]
        public void FinalizeTests()
        {
        }
    }
}
