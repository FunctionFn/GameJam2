class An_Sat : Announcement
{
    private An_Sat()
        : base("Saturday's a special day!", new Threshold(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0))
    {
    }

    public static Announcement getInstance()
    {
        if (instance == null)
        {
            instance = new An_Sat();
        }
        return instance;
    }

    private static Announcement instance;
}
