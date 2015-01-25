

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
        if (!World.getInstance().isNight())
        {
            character.ChangeState(WDWDN_State.getInstance());
        }
    }

    void _State.exit(NPC character)
    {
        System.Console.WriteLine(character.name + " exits Sleep state");
    }
}

