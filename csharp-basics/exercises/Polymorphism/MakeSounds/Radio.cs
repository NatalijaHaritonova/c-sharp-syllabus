using System;

namespace MakeSounds
{
    internal class Radio :ISound
    {
        void ISound.PlaySound()
        {
            Console.WriteLine("ShhhhhSHhh");
        }
    }
}
