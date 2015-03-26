using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TeaPartyKata
{
    [TestClass]
    public class TeaPartyKata
    {
        private SocialEvent se;

        public TeaPartyKata()
        {
            se = new SocialEvent();
        }

        [TestMethod]
        public void SocialEventHasGuestList()
        {
            var guestList = se.getGuestList();
            Assert.IsInstanceOfType(guestList, typeof(List<string>));
        }

        [TestMethod]
        public void addGuest()
        {
            se.addGuest("Andrew");
            Assert.AreEqual(1, se.getGuestList().Count);
        }

        [TestMethod]
        public void GuestListIsNotEmpty()
        {
            int countGuestList = se.getGuestList().Count;
            Assert.IsTrue(countGuestList >= 0);
        }
    }
}
