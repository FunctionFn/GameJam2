using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandmasCode
{
    class Den_State : _State
    {
        private Den_State()
        {
        }

        public static _State getInstance()
        {
            if (instance == null)
            {
                instance = new Den_State();
            }

            return instance;
        }

        void _State.enter(NPC character)
        {
            Console.Write(character.name + "enters the Den");
        }

        void _State.execute(NPC character)
        {
            Console.Write(character.name + " is in the Den");

            World.getInstance().incrementComfort();
            if (World.getInstance().isNight())
            {
                character.ChangeState(Sleep_State.getInstance());
            }
            else if (World.getInstance().getConfortLvl() > character.thresholds.getHiComfort() + World.getInstance().getModifier().getHiComfort())
            {
                character.ChangeState(Decision_State.getInstance());
            }
        }

        void _State.exit(NPC character)
        {
            Console.Write(character.name + "is done in the Den");
        }

        //-------------------------------------------
        private static _State instance;

    }
}
