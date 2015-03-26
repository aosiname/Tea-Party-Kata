using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeaPartyKata
{
    class SocialEvent
    {
        private List<Guest> guests;

        public SocialEvent()
        {
            guests = new List<Guest>();
        }

        public void addGuest(string g)
        {
            //guests.Add(g);
        }

        internal List<Guest> getGuestList()
        {
            return this.guests;
        }



        internal void addGuest(Guest g)
        {
            guests.Add(g);
        }
    }
}
