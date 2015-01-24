using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandmasCode
{
    class Sleep_State : _State
    {
        private static _State instance;

        public _State getInstance()
        {
            if (instance == null)
            {
                instance = new Sleep_State();
            }
            return instance;
        }

        private Sleep_State()
        {
            // Do nothing
        }

        void enter(NPC character)
        {
            Console.WriteLine(character.name + " enters Sleep state");
        }

        void execute(NPC character)
        {
            Console.WriteLine(character.name + " executes Sleep state");
            if (World.isNight())
            {
                //character.ChangeState(WDWDN_State.getInstance());
            }
        }

        void exit(NPC character)
        {
            Console.WriteLine(character.name + " exits Sleep state");
        }
    }
}
