using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_2
{
    class Resource
    {
        public Process ActiveProcess
        {
            get { return activeProcess; }
            set { activeProcess = value; }
        }
        private Process activeProcess;

        public void WorkingCycle()
        {
            if (!IsFree())
            {
                activeProcess.IncreaseWorkTime();
            }
        }

        public bool IsFree()
        {
            return activeProcess == null;
        }

        public void Clear()
        {
            activeProcess = null;
        }
    }
}