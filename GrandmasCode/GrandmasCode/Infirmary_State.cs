using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandmasCode
{
    class Infirmary_State : _State
    {
        private Infirmary_State()
        {
        }

        public static _State getInstance()
        {
            if (instance == null)
            {
                instance = new Infirmary_State();
            }

            return instance;
        }

        void _State.enter(NPC character)
        {
            Console.Write(character.name + "is in the Infirmary");
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
            Console.Write(character.name + "is done in the Infirmary");
        }

        //-------------------------------------------
        private static _State instance;

    }
}
