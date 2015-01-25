
public class WDWDN_State : _State
{
    private static _State instance;

    public static _State getInstance()
    {
        if (instance == null)
        {
            instance = new WDWDN_State();
        }
        return instance;
    }

    private WDWDN_State()
    {
        // Do nothing
    }

    void _State.enter(NPC character)
    {
        System.Console.WriteLine(character.name + " enters WDWDN state");
        character.curr_room.leave();
        character.curr_room = NoRoom.getInstance().enter();
    }

    void _State.execute(NPC character)
    {
        System.Console.WriteLine(character.name + " asks: \"What do we do now?\"");
        character.ChangeState(Decision_State.getInstance());
    }

    void _State.exit(NPC character)
    {
        System.Console.WriteLine(character.name + " exits WDWDN state");
    }
}

