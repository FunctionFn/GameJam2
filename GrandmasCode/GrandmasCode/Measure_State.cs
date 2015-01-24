using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandmasCode
{
    class Measure_State: _State
    {
        void _State.enter(NPC character)
        {
            Console.Write("Entering measure state.");
        }

        void _State.execute(NPC character)
        {
            /*
             * Gets all relevant states for the specific NPC
             * and creates an list (priority queue?) of the 
             * states that are necessary to make decisions based 
             * on levels.
             */

            // initialize values that are relevant to decision-making
            int currentHunger;
            int currentHealth;
            int currentEntertainment;
            int currentComfort;
            int currentMeds;
            int currentFaith;

            // calculate relevant values for decision-making
            currentHunger = character.thresholds.getLowHunger(); // add world, subtract announcement
            currentHealth = character.thresholds.getLowHealth(); // for all
            currentEntertainment = character.thresholds.getLowEntertainment();
            currentComfort = character.thresholds.getLowComfort();
            currentMeds = character.thresholds.getLowMeds();
            currentFaith = character.thresholds.getLowFaith();
          

            // decisionArray.add(currentHunger)
            // decisionArray.add(currentHealth) 
            // decisionArray.add(currentEntertainment) 
            // decisionArray.add(currentComfort) // decisionArray.add(medsThreshold) 
            // decisionArray.add(faithThreshold)

            // decisionArray.sort(ascending)
        }

        void _State.exit(NPC character)
        {
            Console.Write("Exiting measure state.");
        }

    }
}
