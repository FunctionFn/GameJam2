using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandmasCode
{
    class Program
    {
        static void Main(string[] args)
        {
            _State myState = new Measure_State();

            NPC joe = new NPC("joe");

            joe.ChangeState(myState);
        }
    }
}
