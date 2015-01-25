public class NPC
{

    public NPC(string inName)
    {
        this.name = inName;
        this.vit = (int)Constants.STARTING_VIT;
        this.curr_state = Sleep_State.getInstance();
        this.curr_room = BedroomRoom.getInstance();
        this.isWalking = false;
        this.isTalking = false;
    }

    public NPC(
        string inName,
        string sayDecision,
        string sayKitchen,
        string sayGoToKitchen,
        string sayPT,
        string sayGoToPT,
        string sayGarden,
        string sayGoToGarden,
        string sayDen,
        string sayGoToDen,
        string sayInfirmary,
        string sayGoToInfirmary,
        string saySleep,
        string sayGoToSleep,
        string sayReminisce,
        string sayNap,
        string sayWander
        )
    {
        this.name = inName;
        this.vit = (int)Constants.STARTING_VIT;
        this.curr_state = Sleep_State.getInstance();
        this.curr_room = BedroomRoom.getInstance();
        this.isWalking = false;
        this.isTalking = false;
        this.sayDecision = sayDecision;
        this.sayKitchen = sayKitchen;
        this.sayGoToKitchen = sayGoToKitchen;
        this.sayPT = sayPT;
        this.sayGoToPT = sayGoToPT;
        this.sayGarden = sayGarden;
        this.sayGoToGarden = sayGoToGarden;
        this.sayDen = sayDen;
        this.sayGoToDen = sayGoToDen;
        this.sayInfirmary = sayInfirmary;
        this.sayGoToInfirmary = sayGoToInfirmary;
        this.saySleep = saySleep;
        this.sayGoToSleep = sayGoToSleep;
        this.sayReminisce = sayReminisce;
        this.sayNap = sayNap;
        this.sayWander = sayWander;
    }


    public void Update()
    {
        this.curr_state.execute(this);

        if (World.getInstance().getRandom() < Constants.SAY_SOMETHING_CHANCE)
        {
            this.isTalking = true;
        }
    }


    public void ChangeState(_State newState)
    {
        this.curr_state.exit(this);
        this.curr_state = newState;
        this.curr_state.enter(this);
        if (this.curr_state == Decision_State.getInstance())
        {
            this.curr_phrase = this.sayDecision;
        }
        else if (this.curr_state == Sleep_State.getInstance())
        {
            this.curr_phrase = this.saySleep;
        }
        else if (this.curr_state == GoToSleep_State.getInstance())
        {
            this.curr_phrase = this.sayGoToSleep;
        }
        else if (this.curr_state == Kitchen_State.getInstance())
        {
            this.curr_phrase = this.sayKitchen;
        }
        else if (this.curr_state == GoToKitchen_State.getInstance())
        {
            this.curr_phrase = this.sayGoToKitchen;
        }
        else if (this.curr_state == Den_State.getInstance())
        {
            this.curr_phrase = this.sayDen;
        }
        else if (this.curr_state == GoToDen_State.getInstance())
        {
            this.curr_phrase = this.sayGoToDen;
        }
        else if (this.curr_state == Garden_State.getInstance())
        {
            this.curr_phrase = this.sayGarden;
        }
        else if (this.curr_state == GoToGarden_State.getInstance())
        {
            this.curr_phrase = this.sayGoToGarden;
        }
        else if (this.curr_state == PT_State.getInstance())
        {
            this.curr_phrase = this.sayPT;
        }
        else if (this.curr_state == GoToPT_State.getInstance())
        {
            this.curr_phrase = this.sayGoToPT;
        }
        else if (this.curr_state == Reminisce_State.getInstance())
        {
            this.curr_phrase = this.sayReminisce;
        }
        else if (this.curr_state == Nap_State.getInstance())
        {
            this.curr_phrase = this.sayNap;
        }
        else if (this.curr_state == Wander_State.getInstance())
        {
            this.curr_phrase = this.sayWander;
        }
        else if (this.curr_state == Infirmary_State.getInstance())
        {
            this.curr_phrase = this.sayInfirmary;
        }
        else if (this.curr_state == GoToInfirmary_State.getInstance())
        {
            this.curr_phrase = this.sayGoToInfirmary;
        }
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
    public bool isTalking;
    public string curr_phrase = null;

    public string sayDecision = null;
    public string sayKitchen = null;
    public string sayGoToKitchen = null;
    public string sayPT = null;
    public string sayGoToPT = null;
    public string sayGarden = null;
    public string sayGoToGarden = null;
    public string sayDen = null;
    public string sayGoToDen = null;
    public string sayInfirmary = null;
    public string sayGoToInfirmary = null;
    public string saySleep = null;
    public string sayGoToSleep = null;
    public string sayReminisce = null;
    public string sayNap = null;
    public string sayWander = null;


}

