namespace DragRace
{
    public class Tesla : ICar
    {
        private int currentSpeed = 0;
        public string Name { get; set; }
        public Tesla()
        {

        }

        public void SpeedUp()
        {
            currentSpeed++;
        }

        public void SlowDown()
        {
            currentSpeed--;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return "-- silence ---";
        }
    }
}