using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public interface ICar
    {
        string Name { get; set; }
        public void SpeedUp();
        public void SlowDown();
        public string ShowCurrentSpeed();
        public void StartEngine();
    }
}
