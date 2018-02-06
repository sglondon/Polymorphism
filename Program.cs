using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Microwave myMicrowave = new Microwave(1000, "Samsung");
            DishWasher myDishwasher = new DishWasher(0, true);

            myMicrowave.Work();

            myDishwasher.Work();








            //StandardMembership gymMember1 = new StandardMembership(100);
            //VIP gymMember2 = new VIP();

            //gymMember1.Activate();
            //gymMember2.Activate();

        


        }
    }
}
