class An_Fri : Announcement
{
    private An_Fri()
        : base("Friday's a special day!", new Threshold(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0))
    {
    }

    public static Announcement getInstance()
    {
        if (instance == null)
        {
            instance = new An_Fri();
        }
        return instance;
    }

    private static Announcement instance;
}
