class An_Sun : Announcement
{
    private An_Sun()
        : base("Sunday's a special day!", new Threshold(0,0,0,0,0,0,0,0,0,0,0,0))
    {
    }

    public static Announcement getInstance()
    {
        if (instance == null)
        {
            instance = new An_Sun();
        }
        return instance;
    }

    private static Announcement instance;
}


