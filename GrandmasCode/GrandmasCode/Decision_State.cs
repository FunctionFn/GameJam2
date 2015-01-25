using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
 *  THE HOLY FORMULA IS AS FOLLOWS:
 *  CHARACTER STATE PLUS MODIFIER
 *  SUBTRACTED FROM THE WORLD STATE
 *  SORTED IN ASCENDING ORDER:
 *  WORLD VALUE - (CHARACTER VALUE + MOD)
 *  
 */

namespace GrandmasCode
{
    class Decision_State: _State
    {

        private Decision_State()
        {
        }

        public static _State getInstance()
        {
            if (instance == null)
            {
                instance = new Decision_State();
            }

            return instance;
        }
        void _State.enter(NPC character)
        {
            Console.WriteLine("Entering decision state.");
        }

        void _State.execute(NPC character)
        {
            /*
             * Gets all relevant states for the specific NPC
             * and creates an list (priority queue?) of the 
             * states that are necessary to make decisions based 
             * on levels.
             */

            int[] decisionArray = new int[6];

            // initialize values that are relevant to decision-making

            int currentHunger;
            int currentHealth;
            int currentEntertainment;
            int currentComfort;
            int currentMeds;
            int currentFaith;

            int min = int.MaxValue;
            int lowIndex = 0;


            // calculate relevant values for decision-making
            currentHunger =             (World.getInstance().getHungerLvl()
                                            - character.thresholds.getLowHunger()
                                            + World.getInstance().getModifier().getLowHunger());

            currentHealth =             (World.getInstance().getHealthLvl()
                                            - character.thresholds.getLowHealth()
                                            + World.getInstance().getModifier().getLowHealth()); 

            currentEntertainment =      (World.getInstance().getEntertainmentLvl()
                                            - character.thresholds.getLowEntertainment()
                                            + World.getInstance().getModifier().getLowEntertainment());

            currentComfort =            (World.getInstance().getConfortLvl()
                                            - character.thresholds.getLowComfort()
                                            + World.getInstance().getModifier().getLowComfort());

            currentMeds =               (World.getInstance().getHealthLvl()
                                            - character.thresholds.getLowMeds()
                                            + World.getInstance().getModifier().getLowMeds());

            currentFaith =              (World.getInstance().getFaithLvl()
                                            - character.thresholds.getLowFaith()
                                            + World.getInstance().getModifier().getLowFaith());

            decisionArray[0] = currentHunger;
            decisionArray[1] = currentHealth;
            decisionArray[2] = currentEntertainment;
            decisionArray[3] = currentComfort;
            decisionArray[4] = currentMeds;
            decisionArray[5] = currentFaith; //faith is left out right now?

            // Add player choice
            // subtract from this

            //Find priority movement 
            for (int i = 0; i < 4; i++)
            {
                if (decisionArray[i] < min)
                {
                    min = decisionArray[i];
                    lowIndex = i;
                }
            }

            switch (lowIndex)
            {
                case 0:
                    Console.WriteLine("Setting to Kitchen state.");
                    character.ChangeState(Kitchen_State.getInstance());
                    Console.WriteLine("Setting to Kitchen.");
                    break;
                case 1:
                    Console.WriteLine("Setting to PT state.");
                    character.ChangeState(PT_State.getInstance());
                    break;
                case 2:
                    Console.WriteLine("Setting to Garden state.");
                    character.ChangeState(Garden_State.getInstance());  
                    break;
                case 3:
                    Console.WriteLine("Settin to Den state.");
                    character.ChangeState(Den_State.getInstance());
                    break;
                case 4:
                    Console.WriteLine("Setting to Infirmary state.");
                    character.ChangeState(Infirmary_State.getInstance());
                    break;

            }
        }

        void _State.exit(NPC character)
        {
            Console.WriteLine("Exiting decision state.");
        }


        //-------------------------------------------
        private static _State instance;

    }
}
