using System;

namespace DragRace
{
    class Porche : ICar
    {
        private int currentSpeed = 0;
        public string Name { get; set; }
        public Porche()
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

        public void StartEngine()
        {
            Console.WriteLine("-- silence ---");
        }
    }
}
