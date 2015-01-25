public class NPC
{

    public NPC(string inName)
    {
        this.name = inName;
        this.vit = (int)Constants.STARTING_VIT;
        this.curr_state = Sleep_State.getInstance();
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

    //----------------
    public string name;
    public _State curr_state;
    public Threshold thresholds;
    public int vit;

}

