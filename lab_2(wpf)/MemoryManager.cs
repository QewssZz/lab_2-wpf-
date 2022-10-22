using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_2
{
    class MemoryManager
    {
        private Memory memory;

        /*public void Save(long size)
        {
            memory.Save(size);
        }
        public Memory Allocate(Process process)
        {
            if (memory.FreeSize >= process.AddrSpace)
            {
                memory.OccupiedSize += process.AddrSpace;
                return memory;
            }
            return null;
        }
        public Memory Free(Process process)
        {
            memory.OccupiedSize -= process.AddrSpace;
            return memory;
        }*/
        public void Save(Memory memory)
        {
            this.memory = memory;
        }

        public Memory Allocate(Process process)
        {
            if (process.AddrSpace > memory.FreeSize)
            {
                return null;
            }
            memory.FreeSize -= process.AddrSpace;
            return memory;
        }

        public Memory Free(Process process)
        {
            memory.FreeSize += process.AddrSpace;
            return memory;
        }

    }
}
