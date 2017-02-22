using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace Habitat.Main
{
    class Timer
    {
        private long StartTick = 0;

        public Timer()
        {
            Reset();
        }

        [DllImport("kernel32.dll")]
        private static extern long GetTickCount();

        public void Reset()
        {
            StartTick = GetTickCount();
        }

        public long GetTicks()
        {
            long currentTick = 0;
            currentTick = GetTickCount();

            return currentTick - StartTick;
        }
    }
}
