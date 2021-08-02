namespace DragRace
{
    public interface ICar
    {
        string Name { get; set; }
        public void SpeedUp();
        public void SlowDown();
        public string ShowCurrentSpeed();
        public string StartEngine();
    }
}
