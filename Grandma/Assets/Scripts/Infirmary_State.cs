
public class Infirmary_State : _State
{
    private Infirmary_State()
    {
    }

    public static _State getInstance()
    {
        if (instance == null)
        {
            instance = new Infirmary_State();
        }

        return instance;
    }

    void _State.enter(NPC character)
    {
        System.Console.WriteLine(character.name + " entering the Infirmary");
        character.curr_room.leave();
        character.curr_room = InfirmaryRoom.getInstance().enter();
    }

    void _State.execute(NPC character)
    {
        World.getInstance().incrementMeds();
        if (World.getInstance().isNight())
        {
            character.ChangeState(GoToSleep_State.getInstance());
        }
        else if (World.getInstance().getMedsLvl() > character.thresholds.getHiMeds() + World.getInstance().getModifier().getHiMeds())
        {
            character.ChangeState(Decision_State.getInstance());
        }
    }

    void _State.exit(NPC character)
    {
        System.Console.WriteLine(character.name + "is done in the Infirmary");
    }

    //-------------------------------------------
    private static _State instance;

}

