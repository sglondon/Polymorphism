using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
  public class Microwave : Appliance
    {

        //fields
        private int watts;
        private string brand;

        //properties

        public int Watts
        {
            get { return this.watts; }
            set { this.watts = value; }
        }

        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value;}
        }

        //Constructors

        public Microwave()
        {
            //default constructor
        }

        public Microwave(int watts, string brand)
        {
            this.watts = watts;
            this.brand = brand;
        }

        //Methods
        public override void Work()
        {
            Console.WriteLine("I emit radioactive waves.");
            Console.WriteLine("I heat up your food.");
        }
    }
}
