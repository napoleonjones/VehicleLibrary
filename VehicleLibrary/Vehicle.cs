using System;
using System.Collections.Generic;
using System.Text;

using VehicleLibrary.Interfaces;

namespace VehicleLibrary
{
    public abstract class Vehicle : IAccelerate, IDeccelerate
    {
        public int CurrentSpeed { get; set; }

        public int Passengers { get; set; }

        public abstract int Accelerate(int desiredSpeed);
        public abstract int Deccelerate(int desiredSpeed);
    }
}
