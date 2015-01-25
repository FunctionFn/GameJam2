
class GoToSleep_State: _State
{

        private GoToSleep_State()
    {
    }

    public static _State getInstance()
    {
        if (instance == null)
        {
            instance = new GoToSleep_State();
        }

        return instance;
    }

    void _State.enter(NPC character)
    {
        System.Console.WriteLine(character.name + "is going to sleep");
        character.isWalking = true;
    }

    void _State.execute(NPC character)
    {
        // BasicPath.move(room)
        System.Console.WriteLine(character.name + ": 8:30 already?  way past my bedtime");
        if (!character.isWalking)
        {
            character.ChangeState(Sleep_State.getInstance());
        }
  
    }

    void _State.exit(NPC character)
    {
        System.Console.WriteLine(character.name + "is arriving in the bedroom");
    }

    //-------------------------------------------
    private static _State instance;
}

