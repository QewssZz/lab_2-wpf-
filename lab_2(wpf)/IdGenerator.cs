using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_2
{
    class IdGenerator
    {
        private long id;

        public long Id
        {
            get
            {
                return id == long.MaxValue ? 0 : ++id;
            }
        }
        public IdGenerator Clear()
        {
            if (this != null)
            {
                id = 0;
            }
            return this;
        }
    }
}
