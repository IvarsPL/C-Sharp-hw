namespace DragRace
{
    class Mercedes : ICar, INitrousCar
    {
        private int currentSpeed = 0;
        public string Name { get; set; }

        public Mercedes()
        {
            Name = "Merceds";
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

        public void UseNitrousOxideEngine()
        {
            currentSpeed += 5;
        }

        public string StartEngine()
        {
            return "Rrrrr";
        }
    }
}
