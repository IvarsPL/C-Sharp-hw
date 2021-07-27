using System;

namespace DragRace
{
    public class Lexus : ICar, INitrousCar
    {
        private int currentSpeed = 0;
        public string Name { get; set; }
        public Lexus()
        {
            Name = "Lexus";
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

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}