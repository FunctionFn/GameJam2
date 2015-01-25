public class NPC
{

    public NPC(string inName)
    {
        this.name = inName;
        this.vit = (int)Constants.STARTING_VIT;
        this.curr_state = Sleep_State.getInstance();
        this.curr_room = BedroomRoom.getInstance();
        this.isWalking = false;
    }


    public void Update()
    {
        this.curr_state.execute(this);
    }


    public void ChangeState(_State newState)
    {
        this.curr_state.exit(this);
        this.curr_state = newState;
        this.curr_state.enter(this);

    }

    public bool ChangeRoom(Room newRoom)
    {
        bool canChange = newRoom.canEnter() && this.curr_room.canLeave();
        if (canChange)
        {
            this.curr_room.leave();
            this.curr_room = newRoom.enter();
        }
        return canChange;
    }

    //----------------
    public string name;
    public _State curr_state;
    public Room curr_room;
    public Threshold thresholds;
    public int vit;
    public bool isWalking;

}

