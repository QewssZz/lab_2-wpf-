using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_2
{
    class Memory
    {
       
        public long Size { get; private set; }
        public long OccupiedSize { get; set; }
        public long FreeSize { get; private set; }


        public void Save(long size)
        {
            FreeSize = Size = size;
            OccupiedSize = 0;
        }
        public void Clear()
        {
            OccupiedSize = 0;
        }

        /*public bool Allocate(Process process)
        {
            if (process.AddressSpace > FreeSize)
            {
                return false;
            }
            OccupiedSize += process.AddressSpace;
            return true;
        }

        public void Free(Process process)
        {
            OccupiedSize -= process.AddressSpace;
        }*/
    }
}
