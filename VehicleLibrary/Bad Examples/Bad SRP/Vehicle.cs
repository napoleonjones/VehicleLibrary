using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibrary.Bad_Examples.Bar_SRP
{
    public class Vehicle
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int EngineCylinders { get; set; }

        public int EngineIdleRPM { get; set; }

        public int EngineCurrentRPM { get; set; }

        public int EngineMaxRPM { get; set; }

        public int WingSpan { get; set; }

        public int CurrentSpeed { get; set; }

        public int CurrentAltitude { get; set; }

        public int CurrentAngleOfAttack { get; set; }

        public int Passengers { get; set; }

        public void IncreaseSpeed(int desiredSpeed)
        {
            for (var speed = CurrentSpeed; speed < desiredSpeed; speed++)
            {
                for (var rpm = EngineCurrentRPM; rpm < speed + 10; rpm++)
                {
                    EngineCurrentRPM = rpm;
                }
                CurrentSpeed = speed;
            }
        }

        public void DecreaseSpeed(int desiredSpeed)
        {
            for (var speed = CurrentSpeed; speed > desiredSpeed; speed--)
            {
                for (var rpm = EngineCurrentRPM; rpm > speed + 10; rpm--)
                {
                    EngineCurrentRPM = rpm;
                }
                CurrentSpeed = speed;
            }
        }

        public void IncreaseAltitude(int desiredAltitude, int desiredAngleOfAttack)
        {
            for (var alt = CurrentAltitude; alt < desiredAltitude; alt++)
            {
                for (var speed = CurrentSpeed; speed < CurrentSpeed + 25; speed++)
                {
                    for (var rpm = EngineCurrentRPM; rpm < speed + 10; rpm++)
                    {
                        EngineCurrentRPM = rpm;
                    }
                    CurrentSpeed = speed;
                }
                for (var angle = CurrentAngleOfAttack; angle < desiredAngleOfAttack; angle++)
                {
                    CurrentAngleOfAttack = angle;
                }
                CurrentAltitude = alt;
            }

            for (var angle = CurrentAngleOfAttack; angle > 0; angle--)
            {
                CurrentAngleOfAttack = angle;
            }
            for (var speed = CurrentSpeed; speed > CurrentSpeed - 25; speed--)
            {
                for (var rpm = EngineCurrentRPM; rpm > speed + 10; rpm--)
                {
                    EngineCurrentRPM = rpm;
                }
                CurrentSpeed = speed;
            }
        }

        public void DecreaseAltitude(int desiredAltitude, int desiredAngleOfAttack)
        {
            for (var alt = CurrentAltitude; alt > desiredAltitude; alt--)
            {
                for (var angle = CurrentAngleOfAttack; angle > desiredAngleOfAttack; angle--)
                {
                    CurrentAngleOfAttack = angle;
                }
                for (var speed = CurrentSpeed; speed > CurrentSpeed - 25; speed--)
                {
                    for (var rpm = EngineCurrentRPM; rpm > speed + 10; rpm--)
                    {
                        EngineCurrentRPM = rpm;
                    }
                    CurrentSpeed = speed;
                }
                CurrentAltitude = alt;
            }

            for (var speed = CurrentSpeed; speed < CurrentSpeed + 25; speed++)
            {
                for (var rpm = EngineCurrentRPM; rpm < speed + 10; rpm++)
                {
                    EngineCurrentRPM = rpm;
                }
                CurrentSpeed = speed;
            }
            for (var angle = CurrentAngleOfAttack; angle < 0; angle++)
            {
                CurrentAngleOfAttack = angle;
            }
        }
    }
}
