using System;

namespace DragRace
{
    public class Bmw : ICar
    {
        private int currentSpeed = 0;
        public string Name { get; set; }
        public Bmw()
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
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}