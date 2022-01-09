using System;

namespace DragRace
{
    internal class Subaru : ICar, INitro
    {
        private int currentSpeed = 0;

        void ICar.SpeedUp(int speed)
        {
            currentSpeed += speed;
        }

        void ICar.SlowDown(int speed)
        {
            currentSpeed -= speed;
        }

        string ICar.ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("BRRM...BRRM..BRRR...");
        }

        void INitro.UseNitrousOxideEngine()
        {
            currentSpeed += 50;
        }
    }
}
