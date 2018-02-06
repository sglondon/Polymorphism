using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class DishWasher : Appliance
    {
        //fields
        //invisible

        //properties
        public double DecibelLevel { get; set; }
        public bool HasHeatDry { get; set; }


        //Constructors

        public DishWasher()
        {
            //default constructor
        }

        public DishWasher(double decibelLevel, bool hasHeatDry)  
        {
            DecibelLevel = decibelLevel;
            HasHeatDry = hasHeatDry;
        }

        //Methods
        public override void Work()
        {
            Console.WriteLine("I wash your dishes.");
            Console.WriteLine("wash wash wash");
        }
    }
}
