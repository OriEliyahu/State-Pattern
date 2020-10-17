using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            State state = new State();
            state.SetGunLock(new FullAuto());
            state.Shoot();
        }
    }
}
