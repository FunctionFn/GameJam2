using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandmasCode
{
    class Kitchen_State : _State
    {
        private Kitchen_State()
        {
        }

        public static _State getInstance()
        {
            if (instance == null)
            {
                instance = new Kitchen_State();
            }

            return instance;
        }

        void _State.enter(NPC character)
        {
            Console.Write(character.name + " entering the kitchen");
        }

        void _State.execute(NPC character)
        {
            Console.Write(character.name + "is in the kitchen");
            World.getInstance().incrementHunger();
            if (World.getInstance().isNight())
            {
                character.ChangeState(GoToSleep_State.getInstance());
            }
            else if (World.getInstance().getHungerLvl() > character.thresholds.getHiHunger() + World.getInstance().getModifier().getHiHunger())
            {
                character.ChangeState(Decision_State.getInstance());
            }
        }

        void _State.exit(NPC character)
        {
            Console.Write(character.name + " is done in the kitchen");
        }

        //-------------------------------------------
        private static _State instance;

    }
}
