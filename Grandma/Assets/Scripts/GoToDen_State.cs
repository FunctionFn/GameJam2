
public class GoToDen_State : _State
{
    private GoToDen_State()
    {
    }

    public static _State getInstance()
    {
        if (instance == null)
        {
            instance = new GoToDen_State();
        }

        return instance;
    }

    void _State.enter(NPC character)
    {
        System.Console.WriteLine(character.name + "is going to the Den");
    }

    void _State.execute(NPC character)
    {
        // BasicPath.move(room)
        System.Console.WriteLine(character.name + ": chilly in here!  im gonna turn up the thermostat");
        if (World.getInstance().isNight())
        {
            character.ChangeState(GoToSleep_State.getInstance());
        }
        else
        {
            character.ChangeState(Den_State.getInstance());
        }
    }

    void _State.exit(NPC character)
    {
        System.Console.WriteLine(character.name + "is arriving in the Den");
    }

    //-------------------------------------------
    private static _State instance;

}
