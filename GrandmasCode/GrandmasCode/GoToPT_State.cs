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
            Console.Write(character.name + "is going to the Den");
        }

        void _State.execute(NPC character)
        {
            // BasicPath.move(room)
            Console.Write(character.name + ": chilly in here!  im gonna turn up the thermostat");
            character.ChangeState(PT_State.getInstance());
        }

        void _State.exit(NPC character)
        {
            Console.Write(character.name + "is arriving in the Den");
        }

        //-------------------------------------------
        private static _State instance;

    }
}
