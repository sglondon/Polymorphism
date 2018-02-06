using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public abstract class Appliance
    {
        //field
        private bool isElectric;

        //properties
        public bool IsElectric
        {
            get { return this.isElectric; }
            set { this.isElectric = value; }
        }

        //constructors = NONE

        //methods

        public abstract void Work();
    }
}
