
public class PT_State : _State
{
    private PT_State()
    {
    }

    public static _State getInstance()
    {
        if (instance == null)
        {
            instance = new PT_State();
        }

        return instance;
    }

    void _State.enter(NPC character)
    {
        System.Console.WriteLine(character.name + " is entering the Physical Therapy Room");
    }

    void _State.execute(NPC character)
    {
        System.Console.WriteLine(character.name + "is in the Physical Therapy Room");
        World.getInstance().incrementHealth();
        if (World.getInstance().isNight())
        {
            character.ChangeState(GoToSleep_State.getInstance());
        }
        else if (World.getInstance().getHealthLvl() > character.thresholds.getHiHealth() + World.getInstance().getModifier().getHiHealth())
        {
            character.ChangeState(Decision_State.getInstance());
        }
    }

    void _State.exit(NPC character)
    {
        System.Console.WriteLine(character.name + "is done in the Physical Therapy Room");
    }

    //-------------------------------------------
    private static _State instance;

}

