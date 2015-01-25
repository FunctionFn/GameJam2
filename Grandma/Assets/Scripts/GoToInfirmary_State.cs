public class GoToInfirmary_State : _State
{
    private GoToInfirmary_State()
    {
    }

    public static _State getInstance()
    {
        if (instance == null)
        {
            instance = new GoToInfirmary_State();
        }

        return instance;
    }

    void _State.enter(NPC character)
    {
        System.Console.WriteLine(character.name + "is going to the infirmary");
    }

    void _State.execute(NPC character)
    {
        // BasicPath.move(room)
        System.Console.WriteLine(character.name + ": on ma way to take ma meds!");
        if (World.getInstance().isNight())
        {
            character.ChangeState(GoToSleep_State.getInstance());
        }
        else
        {
            character.ChangeState(Infirmary_State.getInstance());
        }
    }

    void _State.exit(NPC character)
    {
        System.Console.WriteLine(character.name + "is arriving in the infirmary");
    }

    //-------------------------------------------
    private static _State instance;

}
