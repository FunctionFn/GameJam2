class An_Mon : Announcement
{
    private An_Mon()
        : base("Monday's a special day!", new Threshold(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0))
    {
    }

    public static Announcement getInstance()
    {
        if (instance == null)
        {
            instance = new An_Mon();
        }
        return instance;
    }

    private static Announcement instance;
}
