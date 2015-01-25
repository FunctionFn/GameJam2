public class AnnouncementMan
{
    private AnnouncementMan()
    {
        this.day = 0;
    }

    public static AnnouncementMan getInstance()
    {
        if (instance == null)
        {
            instance = new AnnouncementMan();
        }
        return instance;
    }

    public Announcement getBottom()
    {
        //enum mostUrgent = World.getInstance().getLeast();

		switch (World.getInstance().getLeast())
        {
            case Conditions.HUNGER:
                return An_Hunger.getInstance();
			case Conditions.HEALTH:
                return An_Health.getInstance();
			case Conditions.MEDS:
                return An_Meds.getInstance();
			case Conditions.ENTERTAINMENT:
                return An_Entertain.getInstance();
            default:
                return An_Comfort.getInstance();
        }

    }

    public Announcement getTop()
    {
		AnnouncementMan announcer = AnnouncementMan.getInstance ();
		announcer.day++;
		if (announcer.day > 6) {
			announcer.day = 0;
		}
		switch (day) {
		case 0:
			return An_Sun.getInstance();
		case 1:
			return An_Mon.getInstance();
		case 2:
			return An_Tue.getInstance();
		case 3:
			return An_Wed.getInstance();
		case 4:
			return An_Thu.getInstance();
		case 5:
			return An_Fri.getInstance();
		default:
			return An_Sat.getInstance();

		}
    }

    //----------------------
    private static AnnouncementMan instance;
    public int day;

}

