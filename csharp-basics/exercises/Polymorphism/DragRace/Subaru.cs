using System;

namespace DragRace
{
    public class Subaru : ICar, INitro
    {
        private int currentSpeed = 0;

        public int SpeedUp(int speed)
        {
            return currentSpeed += speed;
        }

        public int SlowDown(int speed)
        {
            return currentSpeed -= speed;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return "BRRM...BRRM..BRRR...";
        }

        public int UseNitrousOxideEngine()
        {
            return currentSpeed += 50;
        }
    }
}
