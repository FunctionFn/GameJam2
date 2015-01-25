
public class Den_State : _State
{
    private Den_State()
    {
    }

    public static _State getInstance()
    {
        if (instance == null)
        {
            instance = new Den_State();
        }

        return instance;
    }

    void _State.enter(NPC character)
    {
        System.Console.WriteLine(character.name + "enters the Den");
    }

    void _State.execute(NPC character)
    {
        System.Console.WriteLine(character.name + " is in the Den");

        World.getInstance().incrementComfort();
        if (World.getInstance().isNight())
        {
            character.ChangeState(GoToSleep_State.getInstance());
        }
        else if (World.getInstance().getConfortLvl() > character.thresholds.getHiComfort() + World.getInstance().getModifier().getHiComfort())
        {
            character.ChangeState(Decision_State.getInstance());
        }
    }

    void _State.exit(NPC character)
    {
        System.Console.WriteLine(character.name + "is done in the Den");
    }

    //-------------------------------------------
    private static _State instance;

}

