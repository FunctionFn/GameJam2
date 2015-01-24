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


            // calculate relevant values for decision-making
            currentHunger = character.thresholds.getLowHunger(); // add world, add announcement
            currentHealth = character.thresholds.getLowHealth(); // modifier for relevant 
            currentEntertainment = character.thresholds.getLowEntertainment();
            currentComfort = character.thresholds.getLowComfort();
            currentMeds = character.thresholds.getLowMeds();
            currentFaith = character.thresholds.getLowFaith();
          
            // Add player choice

            // subtract currentState from worldState
            
            // put into a priority queue 

            // decisionArray.add(currentHunger)
            // decisionArray.add(currentHealth) 
            // decisionArray.add(currentEntertainment) 
            // decisionArray.add(currentComfort) // decisionArray.add(medsThreshold) 
            // decisionArray.add(faithThreshold)

            // decisionArray.sort(ascending)
        }

        void _State.exit(NPC character)
        {
            Console.WriteLine("Exiting decision state.");
        }


        //-------------------------------------------
        private static _State instance;

    }
}
