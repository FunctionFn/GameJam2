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
            Console.Write(character.name + "is in the kitchen");
        }

        void _State.execute(NPC chararcter)
        {

            while (true)
            {
                break;
            }

            if (false)
            {
                //chararcter.ChangeState(Measure_State.getInstance());
            }
        }

        void _State.exit(NPC character)
        {
            Console.Write(character.name + "is done in the kitchen");
        }

        //-------------------------------------------
        private static _State instance;

    }
}
