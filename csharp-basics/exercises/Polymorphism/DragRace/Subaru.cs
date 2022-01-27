using System;

namespace DragRace
{
    internal class Subaru : ICar, INitro
    {
        private int currentSpeed = 0;

        public void SpeedUp(int speed)
        {
            currentSpeed += speed;
        }

        public void SlowDown(int speed)
        {
            currentSpeed -= speed;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("BRRM...BRRM..BRRR...");
        }

        public void UseNitrousOxideEngine()
        {
            currentSpeed += 50;
        }
    }
}
