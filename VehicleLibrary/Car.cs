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
        public override int Accelerate(int desiredSpeed)
        {
            throw new NotImplementedException();
        }

        public override int Deccelerate(int desiredSpeed)
        {
            throw new NotImplementedException();
        }
    }
}
