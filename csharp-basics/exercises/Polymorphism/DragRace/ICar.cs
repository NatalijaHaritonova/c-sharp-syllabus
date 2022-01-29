namespace DragRace
{
    public interface ICar
    {
        int SpeedUp(int speed);
        int SlowDown(int speed);
        string ShowCurrentSpeed();
        string StartEngine();
    }
}
