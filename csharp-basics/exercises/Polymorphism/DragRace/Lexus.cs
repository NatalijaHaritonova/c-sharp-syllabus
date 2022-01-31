using System;

namespace DragRace
{
    public class Lexus : ICar, INitro
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

        public int UseNitrousOxideEngine() 
        {
            return currentSpeed += 40;
        }

        public string StartEngine() 
        {
            return "Rrrrrrr.....";
        }
    }
}