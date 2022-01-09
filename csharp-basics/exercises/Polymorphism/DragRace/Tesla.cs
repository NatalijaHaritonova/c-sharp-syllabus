using System;

namespace DragRace
{
    public class Tesla : ICar
    {
        private int currentSpeed = 0;

        public void SpeedUp(int speed) 
        {
            currentSpeed += speed;
        }

        public void SlowDown(int speed) 
        {
            currentSpeed += speed;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine("-- silence ---");
        }
    }
}