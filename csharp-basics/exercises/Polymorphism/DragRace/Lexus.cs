using System;

namespace DragRace
{
    public class Lexus : ICar, INitro
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

        public void UseNitrousOxideEngine() 
        {
            currentSpeed += 40;
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}