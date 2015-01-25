class An_Tue : Announcement
{
    private An_Tue()
        : base("Tuesday's a special day!", new Threshold(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0))
    {
    }

    public static Announcement getInstance()
    {
        if (instance == null)
        {
            instance = new An_Tue();
        }
        return instance;
    }

    private static Announcement instance;
}