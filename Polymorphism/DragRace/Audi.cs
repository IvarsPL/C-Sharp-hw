namespace DragRace
{
    public class Audi : ICar
    {
        private int currentSpeed = 0;
        public string Name { get; set; }
        public Audi()
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
            return "Rrrrrrr.....";
        }
    }
}