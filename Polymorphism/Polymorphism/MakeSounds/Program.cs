using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var blueParrot = new Parrot();
            var greenParrot = new Parrot();
            var oneRadio = new Radio();
            var smallRadio = new Radio();
            var loudFirework = new Firework();
            var bigFirework = new Firework();

            var soundList = new List<ISound>()
            {
                blueParrot, greenParrot, oneRadio, smallRadio, loudFirework, bigFirework
            };

            for (int i = 0; i < 5; i++)
            {
                foreach (var sound in soundList) { sound.PlaySound(); }
            }

            Console.Read();
        }
    }
}