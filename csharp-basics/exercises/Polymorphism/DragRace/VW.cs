using System;

namespace DragRace
{
    internal class VW : ICar
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

        void ICar.StartEngine()
        {
            Console.WriteLine("Trtrtr.....");
        }
    }
}
