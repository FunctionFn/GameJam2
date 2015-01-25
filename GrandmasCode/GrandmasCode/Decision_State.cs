

/* 
*  THE HOLY FORMULA IS AS FOLLOWS:
*  CHARACTER STATE PLUS MODIFIER
*  SUBTRACTED FROM THE WORLD STATE
*  SORTED IN ASCENDING ORDER:
*  WORLD VALUE - (CHARACTER VALUE + MOD)
*  
*/


public class Decision_State : _State
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
        System.Console.WriteLine(character.name + " Entering decision state.");
        character.curr_room.leave();
        character.curr_room = NoRoom.getInstance().enter();
    }

    void _State.execute(NPC character)
    {
        System.Console.WriteLine(character.name + " deciding...");
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
        currentHunger = (World.getInstance().getHungerLvl()
                                        - character.thresholds.getLowHunger()
                                        + World.getInstance().getModifier().getLowHunger());

        currentHealth = (World.getInstance().getHealthLvl()
                                        - character.thresholds.getLowHealth()
                                        + World.getInstance().getModifier().getLowHealth());

        currentEntertainment = (World.getInstance().getEntertainmentLvl()
                                        - character.thresholds.getLowEntertainment()
                                        + World.getInstance().getModifier().getLowEntertainment());

        currentComfort = (World.getInstance().getConfortLvl()
                                        - character.thresholds.getLowComfort()
                                        + World.getInstance().getModifier().getLowComfort());

        currentMeds = (World.getInstance().getHealthLvl()
                                        - character.thresholds.getLowMeds()
                                        + World.getInstance().getModifier().getLowMeds());

        currentFaith = (World.getInstance().getFaithLvl()
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
        for (int i = 0; i < 5; i++)
        {
            if (decisionArray[i] < min)
            {
                min = decisionArray[i];
                lowIndex = i;
            }
        }

        if (World.getInstance().getRandom() < Constants.NAP_CHANCE)
        {
            character.ChangeState(Nap_State.getInstance());
        }
        else if (World.getInstance().getRandom() < Constants.REMINISCE_CHANCE)
        {
            character.ChangeState(Reminisce_State.getInstance());
        }
        else if (World.getInstance().getRandom() < Constants.WANDER_CHANCE)
        {
            character.ChangeState(Wander_State.getInstance());
        }
        else
        {
            switch (lowIndex)
            {
                case 0:
                    System.Console.WriteLine("Setting to Kitchen state.");
                    character.ChangeState(GoToKitchen_State.getInstance());
                    System.Console.WriteLine("Setting to Kitchen.");
                    break;
                case 1:
                    System.Console.WriteLine("Setting to PT state.");
                    character.ChangeState(GoToPT_State.getInstance());
                    break;
                case 2:
                    System.Console.WriteLine("Setting to Garden state.");
                    character.ChangeState(GoToGarden_State.getInstance());
                    break;
                case 3:
                    System.Console.WriteLine("Settin to Den state.");
                    character.ChangeState(GoToDen_State.getInstance());
                    break;
                case 4:
                    System.Console.WriteLine("Setting to Infirmary state.");
                    character.ChangeState(GoToInfirmary_State.getInstance());
                    break;

            }
        }
    }

    void _State.exit(NPC character)
    {
        System.Console.WriteLine(character.name + " Exiting decision state.");
    }


    //-------------------------------------------
    private static _State instance;

}

