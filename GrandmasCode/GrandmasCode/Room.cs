using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandmasCode
{
    class Room
    {
        private int capacity;
        private int occupancy;

        public Room(int capacity)
        {
            this.capacity = capacity;
        }

        public bool enter()
        {
            bool returnValue = false;
            if (this.occupancy < this.capacity)
            {
                this.occupancy++;
                returnValue = true;
            }
            return returnValue;
        }

        public bool leave()
        {
            bool returnValue = false;
            if (this.occupancy > 0)
            {
                this.occupancy--;
                returnValue = true;
            }
            return returnValue;
        }
    }
}
