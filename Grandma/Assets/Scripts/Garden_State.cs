

public class Garden_State : _State
{
    private Garden_State()
    {
    }

    public static _State getInstance()
    {
        if (instance == null)
        {
            instance = new Garden_State();
        }

        return instance;
    }

    void _State.enter(NPC character)
    {
        System.Console.WriteLine(character.name + "enters the Garden");
        character.curr_room.leave();
        character.curr_room = GardenRoom.getInstance().enter();
    }

    void _State.execute(NPC character)
    {
        System.Console.WriteLine(character.name + "enters the Garden");

        World.getInstance().incrementEntertainment();
        if (World.getInstance().isNight())
        {
            character.ChangeState(GoToSleep_State.getInstance());
        }
        else if (World.getInstance().getEntertainmentLvl() > character.thresholds.getHiEntertainment() + World.getInstance().getModifier().getHiEntertainment())
        {
            character.ChangeState(Decision_State.getInstance());
        }
    }

    void _State.exit(NPC character)
    {
        System.Console.WriteLine(character.name + "is done in the Garden");
    }

    //-------------------------------------------
    private static _State instance;

}

