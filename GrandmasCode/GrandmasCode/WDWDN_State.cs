using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandmasCode
{
    class WDWDN_State : _State
    {
        private static _State instance;

        public _State getInstance()
        {
            if (instance == null)
            {
                instance = new WDWDN_State();
            }
            return instance;
        }

        private WDWDN_State()
        {
            // Do nothing
        }

        void _State.enter(NPC character)
        {
            Console.WriteLine(character.name + " enters WDWDN state");
        }

        void _State.execute(NPC character)
        {
            Console.WriteLine(character.name + " asks: \"What do WeakReference do now?\"");
            character.ChangeState(Decision_State.getInstance());
        }

        void _State.exit(NPC character)
        {
            Console.WriteLine(character.name + " exits Sleep state");
        }
    }
}
