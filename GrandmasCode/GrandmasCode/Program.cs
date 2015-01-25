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
            NPC npc = new NPC("Joe");

            while (true)
            {
                World.getInstance().update();
                npc.Update();
            }
            //_State myState = new Decision_State().get;

            //NPC joe = new NPC("joe");

            //joe.ChangeState(myState);
        }
    }
}
