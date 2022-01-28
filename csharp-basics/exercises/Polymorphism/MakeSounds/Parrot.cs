using System;

namespace MakeSounds
{
    internal class Parrot :ISound
    {
        void ISound.PlaySound()
        {
            Console.WriteLine("Arrrr..");
        }
    }
}
