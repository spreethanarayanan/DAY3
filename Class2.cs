using System;
using System.Collections.Generic;
using System.Text;

namespace day3programs
{
  interface vehicle
    {
        void ChangeGear(int a);
        void speedup(int a);
        void applyBrakes(int a);
    }
    class Bicycle:Vehicle
    {
        int speed;
        int gear;
        public void ChangeGear(int newGear)
        {
            gear = newGear;
        }
        public void speedUp(int increment)
        {
            speed = speed + increment;
        }
        public void applyBreakes(int decrement)
        {
            speed = speed - decrement;
        }
        public void printStates()
        {
            Console.WriteLine("speed: " + speed + "gear:" + "gear");
        }
    }
    class Client
    {
        public static void Main()
        {
            Bicycle bicycle = new Bicycle();
            bicycle.ChangeGear(2);
            bicycle.speedUp(3);
            bicycle.applyBreakes(1);
            Console.ReadLine();

        }
    }

}
