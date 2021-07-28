using System;

namespace MakeSounds
{
    class Radio : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("random radio noises");
        }
    }
}
