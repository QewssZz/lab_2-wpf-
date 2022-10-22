using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_2
{
    class SystemClock
    {
        private long clock;

        public long Clock
        {
            get
            {
                return clock;
            }
            private set
            {
                clock = value;
            }
        }

        public void WorkingCycle()
        {
            clock++;
        }
        public void Clear()
        {
            clock = 0;
        }
    }
}