using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_2
{
    class MemoryManager
    {
        private Memory memory;

        public void Save(Memory memory)
        {
            this.memory = memory;
        }

        public Memory Allocate(Process process)
        {
            /*if (process.AddrSpace > memory.FreeSize)
            {
                return null;
            }
            memory.OccupiedSize -= process.AddrSpace;
            return memory;*/
            if (memory.FreeSize >= process.AddrSpace)
            {
                memory.OccupiedSize += process.AddrSpace;
                return memory;
            }
            return null;
        }

        public Memory Free(Process process)
        {
            memory.OccupiedSize += process.AddrSpace;
            return memory;
        }

    }
}
