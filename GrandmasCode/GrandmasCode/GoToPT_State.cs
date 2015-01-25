using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandmasCode
{
    class GoToPT_State : _State
    {
        private GoToPT_State()
        {
        }

        public static _State getInstance()
        {
            if (instance == null)
            {
                instance = new GoToPT_State();
            }

            return instance;
        }

        void _State.enter(NPC character)
        {
            Console.Write(character.name + "is going to the physical therapy");
        }

        void _State.execute(NPC character)
        {
            // BasicPath.move(room)
            Console.Write(character.name + ": i feel stiff as a board.  but i hate my physical therapy");
            if (World.getInstance().isNight())
            {
                character.ChangeState(GoToSleep_State.getInstance());
            }
            else
            {
                character.ChangeState(PT_State.getInstance());
            }
        }

        void _State.exit(NPC character)
        {
            Console.Write(character.name + "is arriving in the physical therapy");
        }

        //-------------------------------------------
        private static _State instance;

    }
}
