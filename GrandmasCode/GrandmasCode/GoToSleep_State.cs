using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandmasCode
{
    class GoToSleep_State: _State
    {

         private GoToSleep_State()
        {
        }

        public static _State getInstance()
        {
            if (instance == null)
            {
                instance = new GoToSleep_State();
            }

            return instance;
        }

        void _State.enter(NPC character)
        {
            Console.Write(character.name + "is going to sleep");
        }

        void _State.execute(NPC character)
        {
            // BasicPath.move(room)
            Console.Write(character.name + ": 8:30 already?  way past my bedtime");
            
            character.ChangeState(Sleep_State.getInstance());
  
        }

        void _State.exit(NPC character)
        {
            Console.Write(character.name + "is arriving in the bedroom");
        }

        //-------------------------------------------
        private static _State instance;
    }
}
