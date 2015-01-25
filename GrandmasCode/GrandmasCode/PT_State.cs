using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandmasCode
{
    class PT_State : _State
    {
        private PT_State()
        {
        }

        public static _State getInstance()
        {
            if (instance == null)
            {
                instance = new PT_State();
            }

            return instance;
        }

        void _State.enter(NPC character)
        {
            Console.Write(character.name + " is entering the Physical Therapy Room");
        }

        void _State.execute(NPC character)
        {
            Console.Write(character.name + "is in the Physical Therapy Room");
            World.getInstance().incrementHealth();
            if (World.getInstance().isNight())
            {
                character.ChangeState(Sleep_State.getInstance());
            }
            else if (World.getInstance().getHealthLvl() > character.thresholds.getHiHealth() + World.getInstance().getModifier().getHiHealth())
            {
                character.ChangeState(Decision_State.getInstance());
            }
        }

        void _State.exit(NPC character)
        {
            Console.Write(character.name + "is done in the Physical Therapy Room");
        }

        //-------------------------------------------
        private static _State instance;

    }
}
