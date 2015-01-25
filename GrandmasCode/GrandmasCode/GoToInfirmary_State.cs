using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandmasCode
{
    class GoToInfirmary_State : _State
    {
        private GoToInfirmary_State()
        {
        }

        public static _State getInstance()
        {
            if (instance == null)
            {
                instance = new GoToInfirmary_State();
            }

            return instance;
        }

        void _State.enter(NPC character)
        {
            Console.Write(character.name + "is going to the infirmary");
        }

        void _State.execute(NPC character)
        {
            // BasicPath.move(room)
            Console.Write(character.name + ": on ma way to take ma meds!");
            if (World.getInstance().isNight())
            {
                character.ChangeState(Sleep_State.getInstance());
            }
            else
            {
                character.ChangeState(Infirmary_State.getInstance());
            }
        }

        void _State.exit(NPC character)
        {
            Console.Write(character.name + "is arriving in the infirmary");
        }

        //-------------------------------------------
        private static _State instance;

    }
}
