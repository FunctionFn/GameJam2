class An_Thu : Announcement
{
    private An_Thu()
        : base("Thursday's a special day!", new Threshold(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0))
    {
    }

    public static Announcement getInstance()
    {
        if (instance == null)
        {
            instance = new An_Thu();
        }
        return instance;
    }

    private static Announcement instance;
}
