using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
   public class Membership
    {

        //fields;

        private int memberID;
        private bool isActive;

        //Properties

        public int MemberID  //who are we writing the app for
                             //if administrator might want to be able to set the id
        {
            get { return this.memberID; }
            set { this.memberID = value; }
        }

        public bool IsActive
        {
            get { return this.isActive; }
            set { this.isActive = value; }
        }

        //Constructors
        public Membership()
        {
            //default constructor
        }

        public Membership(int memberID, bool isActive)
        {
            this.memberID = memberID; //first this is refers to field, after = refers to property
            this.IsActive = isActive; //refers to field, after = refers to property

        }

        //Method

        public virtual void Activate()
        {
            if (isActive == false) //checks equality
            {
                isActive = true;  //assigns value
                Console.WriteLine("Your membership has been activated.");
            }
            else
            {
                Console.WriteLine("Your membership is already active.");
            }
        }


    }
}
