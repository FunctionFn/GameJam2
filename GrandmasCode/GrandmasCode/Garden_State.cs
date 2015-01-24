using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandmasCode
{
    class Garden_State : _State
    {
        private Garden_State()
        {
        }

        public static _State getInstance()
        {
            if (instance == null)
            {
                instance = new Garden_State();
            }

            return instance;
        }

        void _State.enter(NPC character)
        {
            Console.Write(character.name + "enters the Garden");
        }

        void _State.execute(NPC character)
        {
            Console.Write(character.name + "enters the Garden");

            World.getInstance().incrementEntertainment();
            if (World.getInstance().isNight())
            {
                character.ChangeState(Sleep_State.getInstance());
            }
            else if (World.getInstance().getEntertainmentLvl() > character.thresholds.getHiEntertainment() + World.getInstance().getModifier().getHiEntertainment())
            {
                character.ChangeState(Decision_State.getInstance());
            }
        }

        void _State.exit(NPC character)
        {
            Console.Write(character.name + "is done in the Garden");
        }

        //-------------------------------------------
        private static _State instance;

    }
}
