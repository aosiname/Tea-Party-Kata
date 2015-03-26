using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeaPartyKata
{
    class Guest
    {
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private bool isWoman;

        public bool IsWoman
        {
            get { return isWoman; }
            set { isWoman = value; }
        }

        private bool isSir;

        public bool IsSir
        {
            get { return isSir; }
            set { isSir = value; }
        }

        public Guest(string lN, bool iW, bool iS)
        {
            this.lastName = lN;
            this.isWoman = iW;
            this.isSir = iS;
        }
    }
}
