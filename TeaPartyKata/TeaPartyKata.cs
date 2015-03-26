using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TeaPartyKata
{
    [TestClass]
    public class TeaPartyKata : ITeaPartyKata
    {
        private SocialEvent se;
        private Guest g;

        public TeaPartyKata()
        {
            se = new SocialEvent();
            
        }

        public string Welcome(string lastName, bool isWoman, bool isSir)
        {
            string title = (!isSir && !isWoman) ? "Mr." : (isSir) ? "Sir" : "Ms."; 
            string result = string.Format("Hello {0} {1}", title, lastName);
            return result;
        }

        [TestMethod]
        public void AustenGreetedCorrectly()
        {
            g = new Guest("Austen", true, false);
            string greeting = Welcome(g.LastName, g.IsWoman, g.IsSir);
            Assert.AreEqual("Hello Ms. Austen", greeting);
        }

        [TestMethod]
        public void NewtonGreetedCorrectly()
        {
            g = new Guest("Newton", false, true);
            string greeting = Welcome(g.LastName, g.IsWoman, g.IsSir);
            Assert.AreEqual("Hello Sir Newton", greeting);
        }

        [TestMethod]
        public void OrwellGreetedCorrectly()
        {
            g = new Guest("Orwell", false, false);
            string greeting = Welcome(g.LastName, g.IsWoman, g.IsSir);
            Assert.AreEqual("Hello Mr. Orwell", greeting);
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
