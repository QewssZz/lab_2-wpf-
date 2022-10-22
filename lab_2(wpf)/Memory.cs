using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_2
{
    class Memory
    {
        public long Size { get; private set; }
        private long size;
        /*private long occupiedSize;
        public long OccupiedSize { get; set; }
        public long FreeSize
        {
            get { return Size - occupiedSize; }
            //private set;
        }*/
        public long FreeSize
        {
            get;
            set;
        }


        /*public void Save(long size)
        {
            Size = size;
            occupiedSize = 0;
        }
        public void Clear()
        {
            occupiedSize = 0;
        }*/

        public void Save(long size)
        {
            FreeSize = this.size = size;
        }

        public void Clear()
        {
            FreeSize = Size;
        }
    }
}
