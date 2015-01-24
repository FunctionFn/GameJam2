using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandmasCode
{
    class GoTo_State: _State
    {
        void _State.enter(NPC character)
        {
            Console.Write("entering goto state");
        }

        void _State.execute(NPC chararcter)
        {

        }

        void _State.exit(NPC character)
        {
            Console.Write("exiting goto state");
        }

    }
}
