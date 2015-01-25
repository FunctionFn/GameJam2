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
        enum mostUrgent = World.getInstance().getLeast();

        switch (mostUrgent)
        {
            case HUNGER:
                return An_Hunger.getInstance();
            case HEALTH:
                return An_Health.getInstance();
            case MEDS:
                return An_Meds.getInstance();
            case ENERTAINMENT:
                return An_Entertain.getInstance();
            case default:
                return An_Comfort.getInstance();
        }

    }

    public Announcement getTop()
    {
        
    }

    //----------------------
    private static AnnouncementMan instance;
    public int day;

}

