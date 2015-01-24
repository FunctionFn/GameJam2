using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandmasCode
{
    class GoToKitchen_State: _State
    {
        private GoToKitchen_State()
        {
        }

        public _State getInstance()
        {
            if (instance == null)
            {
                instance = new GoToKitchen_State();
            }

            return instance;
        }

        void _State.enter(NPC character)
        {
            Console.Write(character.name + "entering goto state");
        }

        void _State.execute(NPC chararcter)
        {
            
        }

        void _State.exit(NPC character)
        {
            Console.Write(character.name + "exiting goto state");
        }

        //-------------------------------------------
        private static _State instance;


    }
}
