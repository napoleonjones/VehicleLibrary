using System;
using System.Collections.Generic;
using System.Text;

using VehicleLibrary.Interfaces;

namespace VehicleLibrary
{
    public abstract class Vehicle : IAccelerate, IDecelerate
    {
        public int CurrentSpeed { get; set; }

        public int Passengers { get; set; }

        public abstract void Accelerate(int desiredSpeed);
        public abstract void Decelerate(int desiredSpeed);
    }
}
