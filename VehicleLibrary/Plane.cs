using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLibrary
{
    public class Plane : Vehicle
    {
        public int WingSpan { get; set; }

        public int CurrentAltitude { get; set; }

        public int CurrentAngleOfAttack { get; set; }

        public ICollection<Engine> Engines { get; set; }

        public Plane()
        {
            var engine1 = new Engine();
            var engine2 = new Engine();

            Engines = new List<Engine>();
            Engines.Add(engine1);
            Engines.Add(engine2);
        }

        public override void Accelerate(int desiredSpeed)
        {
            for (var speed = CurrentSpeed; CurrentSpeed < desiredSpeed; speed++)
            {                
                Parallel.ForEach(Engines, engine =>
                {
                    engine.IncreaseRPM(speed + 10);
                });
                CurrentSpeed = speed;
            }
        }

        public override void Decelerate(int desiredSpeed)
        {
            for (var speed = CurrentSpeed; CurrentSpeed > desiredSpeed; speed--)
            {
                Parallel.ForEach(Engines, engine =>
                {
                    engine.IncreaseRPM(speed - 10);
                });
                CurrentSpeed = speed;
            }
        }

        public void IncreaseAltitude(int desiredAltitude)
        {
            for (var alt = CurrentAltitude; alt < desiredAltitude; alt++)
            {
                Accelerate(CurrentSpeed + 25);
                IncreaseAngleOfAttack(CurrentAngleOfAttack + 10);
                CurrentAltitude = alt;
            }

            DecreaseAngleOfAttack(CurrentAngleOfAttack - 10);
            Decelerate(CurrentSpeed - 25);
        }

        public void DecreaseAltitude(int desiredAltitude)
        {
            for (var alt = CurrentAltitude; alt > desiredAltitude; alt--)
            {
                DecreaseAngleOfAttack(CurrentAngleOfAttack - 10);
                Decelerate(CurrentSpeed - 25);
                CurrentAltitude = alt;
            }

            Accelerate(CurrentSpeed - 25);
            IncreaseAngleOfAttack(CurrentAngleOfAttack + 10);
        }

        public void IncreaseAngleOfAttack(int desiredAngleOfAttack)
        {
            for (var angle = CurrentAngleOfAttack; angle < desiredAngleOfAttack; angle++)
            {
                CurrentAngleOfAttack = angle;
            }
        }

        public void DecreaseAngleOfAttack(int desiredAngleOfAttack)
        {
            for (var angle = CurrentAngleOfAttack; angle > desiredAngleOfAttack; angle--)
            {
                CurrentAngleOfAttack = angle;
            }
        }
    }
}
