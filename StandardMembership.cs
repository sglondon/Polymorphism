using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class StandardMembership : Membership  //references base class
    {

        //fields
        //invisible

        //Properties

        public int Cost { get; set; }  //shorthand for get set and creates lowercase field behind the scenes

        //constructors
        public StandardMembership()
        {
            //default constructor
        } 

        public StandardMembership(int cost)  //overloaded constructor
        {
            Cost = cost;
        }

        //Methods

        public override void Activate()
        {
            if (IsActive == false) //checks equality
            {
                IsActive = true;  //assigns value
                Console.WriteLine("Your standard membership has been activated.");
            }
            else
            {
                Console.WriteLine("Your standard membership is already active.");
            }
        }


    }                                   
}
