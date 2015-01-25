class An_Wed : Announcement
{
    private An_Wed()
        : base("Wednesday's a special day!", new Threshold(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0))
    {
    }

    public static Announcement getInstance()
    {
        if (instance == null)
        {
            instance = new An_Wed();
        }
        return instance;
    }

    private static Announcement instance;
}