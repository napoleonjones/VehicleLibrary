using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibrary
{
    public class Engine
    {
        public int CurrentRPM { get; set; }

        public int Cylinders { get; set; }

        public int MaxRPM { get; set; }

        public Engine()
        {

        }

        public void IncreaseRPM(int desiredRPM)
        {
            for (var rpm = CurrentRPM; rpm < desiredRPM; rpm++)
            {
                CurrentRPM = rpm;
            }
        }

        public void DecreaseRPM(int desiredRPM)
        {
            for (var rpm = CurrentRPM; rpm > desiredRPM; rpm--)
            {
                CurrentRPM = rpm;
            }
        }
    }
}
