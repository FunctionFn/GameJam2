using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandmasCode
{
    class GoToGarden_State : _State
    {
        private GoToGarden_State()
        {
        }

        public static _State getInstance()
        {
            if (instance == null)
            {
                instance = new GoToGarden_State();
            }

            return instance;
        }

        void _State.enter(NPC character)
        {
            Console.Write(character.name + "is going to the Garden");
        }

        void _State.execute(NPC character)
        {
            // BasicPath.move(room)
            Console.Write(character.name + ": there's nothing to do in here!  im playin shuffleboard");
            if (World.getInstance().isNight())
            {
                character.ChangeState(Sleep_State.getInstance());
            }
            else
            {
                character.ChangeState(Garden_State.getInstance());
            }
        }

        void _State.exit(NPC character)
        {
            Console.Write(character.name + "is arriving in the Garden");
        }

        //-------------------------------------------
        private static _State instance;

    }
}
