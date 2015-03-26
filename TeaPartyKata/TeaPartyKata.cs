using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TeaPartyKata
{
    [TestClass]
    public class TeaPartyKata
    {
        private SocialEvent se;
        private Guest g;

        public TeaPartyKata()
        {
            se = new SocialEvent();
            g = new Guest();
        }

        [TestMethod]
        public void SocialEventHasGuestList()
        {
            var guestList = se.getGuestList();
            Assert.IsInstanceOfType(guestList, typeof(List<Guest>));
        }

        [TestMethod]
        public void addGuest()
        {
            se.addGuest(g);
            Assert.AreEqual(1, se.getGuestList().Count);
        }


    }
}
