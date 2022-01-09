using System;

namespace DragRace
{
    public class Audi : ICar
    {
        private int currentSpeed = 0;

        void ICar.SpeedUp(int speed)
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
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}