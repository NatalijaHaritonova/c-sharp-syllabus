namespace DragRace
{
    internal interface ICar
    {
        void SpeedUp(int speed);
        void SlowDown(int speed);
        string ShowCurrentSpeed();
        void StartEngine();
    }
}
