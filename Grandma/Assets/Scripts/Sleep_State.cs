﻿

public class Sleep_State : _State
{
    private static _State instance;

    public static _State getInstance()
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

    void _State.enter(NPC character)
    {
        System.Console.WriteLine(character.name + " enters Sleep state");
        character.curr_room.leave();
        character.curr_room = BedroomRoom.getInstance().enter();
    }

    void _State.execute(NPC character)
    {
        System.Console.WriteLine(character.name + " executes Sleep state");

        // calculate change to vitality
        // if NPC.threshold.lowestthreshold

        
		int[] decisionArray = new int[6];
		int min = int.MaxValue;
		int lowIndex = 0;
		
		decisionArray[0] = World.getInstance().getHungerLvl() - character.thresholds.getLowHunger();
		decisionArray[1] = World.getInstance().getHealthLvl() - character.thresholds.getLowHealth();
        decisionArray[2] = World.getInstance().getEntertainmentLvl() - character.thresholds.getLowEntertainment();
        decisionArray[3] = World.getInstance().getComfortLvl() - character.thresholds.getLowComfort();
        decisionArray[4] = World.getInstance().getMedsLvl() - character.thresholds.getLowMeds();
        decisionArray[5] = World.getInstance().getFaithLvl() - character.thresholds.getLowFaith();
			
		for (int i = 0; i <= 5; i++)
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
                character.vit -= decisionArray[0];
                break;
			case 1:
                character.vit -= decisionArray[1];
                break;
			case 2:
                character.vit -= decisionArray[2];
                break;
			case 3:
                character.vit -= decisionArray[3];
                break;
			case 4:
				character.vit -= decisionArray[4];
                break;
            default:
                character.vit -= decisionArray[5];
                break;
		}

        if (character.vit <= 0)
        {
            character.ChangeState(Kill_State.getInstance());
        }

        if (character.vit > 100)
        {
            character.vit = 100;
        }

        if (!World.getInstance().isNight() & character.vit > 0)
        {
            character.ChangeState(WDWDN_State.getInstance());
        }
    }

    void _State.exit(NPC character)
    {
        System.Console.WriteLine(character.name + " exits Sleep state");
    }
}

