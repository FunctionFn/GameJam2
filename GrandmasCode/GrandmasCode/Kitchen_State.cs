﻿
public class Kitchen_State : _State
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
        System.Console.WriteLine(character.name + " entering the kitchen");
        character.curr_room.leave();
        character.curr_room = KitchenRoom.getInstance().enter();
    }

    void _State.execute(NPC character)
    {
        System.Console.WriteLine(character.name + "is in the kitchen");
        World.getInstance().incrementHunger();
        if (World.getInstance().isNight())
        {
            character.ChangeState(GoToSleep_State.getInstance());
        }
        else if (World.getInstance().getHungerLvl() > character.thresholds.getHiHunger() + World.getInstance().getModifier().getHiHunger())
        {
            character.ChangeState(Decision_State.getInstance());
        }
    }

    void _State.exit(NPC character)
    {
        System.Console.WriteLine(character.name + " is done in the kitchen");
    }

    //-------------------------------------------
    private static _State instance;

}

