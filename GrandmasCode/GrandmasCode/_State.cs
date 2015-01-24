using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandmasCode
{
    interface _State
    {
        void enter(NPC character);
        

        void execute(NPC character);


        void exit(NPC character);
        


    }
}
