class An_Hunger : Announcement
{
    private An_Hunger()
        : base("Don't skip meals everyone,\nTreat yourself to something hardy", new Threshold(15, 15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0))
    {
    }

    public static Announcement getInstance()
    {
        if (instance == null)
        {
            instance = new An_Hunger();
        }
        return instance;
    }

    private static Announcement instance;
}
