using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_2
{
    enum ProcessStatus { ready, running, waiting, terminated }

    class Process : IComparable<Process>// IComparable
    {
        private long id;
        private string name;
        private long workTime;
        private Random rand;

        public event EventHandler FreeingAResource;

        private void OnFreeResource(object sender, EventArgs e) 
        {
            if (FreeingAResource != null) 
            {
                FreeingAResource(sender, e);
            }
        }
        public long BurstTime { get; set; }
        public ProcessStatus Status { get; set; }
        public long AddrSpace { get; }
        public Process(long pId, long addrSpace)
        {
            id = pId;
            name = "p" + id;
            AddrSpace = addrSpace;
            Status = ProcessStatus.ready;
        }

        public void IncreaseWorkTime()
        {
            if (workTime < BurstTime)
            {
                workTime++;
                return;
            }
            /*if (Status == ProcessStatus.running)
            {
                Status = rand.Next(0, 2) == 0 ? ProcessStatus.terminated : ProcessStatus.waiting;
            }
            else
            {
                Status = ProcessStatus.ready;
            }*/
            FreeingAResource(this, null);
        }
        public void ResetWorkTime()
        {
            workTime = 0;
        }
        public override string ToString()
        {
            return "Id: " + id + "; Burst time: " + BurstTime + "; Status: " 
                + Status + "Work time: " + workTime;
            // добавить workTime
        }

        /*public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            Process otheProcess = obj as Process;
            if (otheProcess != null)
            {
                if (BurstTime > otheProcess.BurstTime)
                {
                    return -1;
                }
                return BurstTime < otheProcess.BurstTime ? 1 : 0;
            }
            else
            {
                throw new ArgumentException("Object is not a Process");
            }
        }*/
        public int CompareTo(Process otherProc)
        {
            if (otherProc == null)
            {
                return 1;
            }
            return otherProc.BurstTime.CompareTo(BurstTime);
        }
    }
}