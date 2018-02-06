using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
   public class VIP : Membership  //inherits from membership
    {
        //fields
        //invisible

        //Properties
        public bool IsSwanky { get; set; } //creates private isSwanky field behind the scenes, set allows us to change it.

        //Constructors

        public VIP()
        {
            //default constructor == no parameters, could have something in the body
        }
        public VIP(bool isSwanky) //this bool isn't the same as the field or property, but convention is to name them the same
        {                               //this is actually a new var that has the same name
            this.IsSwanky = isSwanky;  //new variable is now set to the value of the property,the var is isSwanky, it's not a field

        }
        //methods

        public override void Activate()
        {
            IsSwanky = true;  //will always be set to true because it's outside of the if statment

            if (IsActive == false) //checks equality
            {
                IsActive = true;  //assigns value
                Console.WriteLine("You are now a big deal!");
            }
            else
            {
                Console.WriteLine("You're already a big deal.");
            }
        }


    }

}
