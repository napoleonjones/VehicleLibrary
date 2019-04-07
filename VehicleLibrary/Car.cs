using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibrary
{
    public class Car : Vehicle
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public Engine Engine { get; set; }

        public Car()
        {
            Engine = new Engine();
        }
        public override void Accelerate(int desiredSpeed)
        {
            for (var speed = CurrentSpeed; CurrentSpeed < desiredSpeed; speed++)
            {
                Engine.IncreaseRPM(speed + 10);
                CurrentSpeed = speed;
            }
        }

        public override void Decelerate(int desiredSpeed)
        {
            for (var speed = CurrentSpeed; CurrentSpeed > desiredSpeed; speed--)
            {
                Engine.DecreaseRPM(speed - 10);
                CurrentSpeed = speed;
            }
        }
    }
}
