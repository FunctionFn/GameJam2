class An_Entertain : Announcement
{
    private An_Entertain()
        : base("Entertainday's a special day!", new Threshold(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0))
    {
    }

    public static Announcement getInstance()
    {
        if (instance == null)
        {
            instance = new An_Entertain();
        }
        return instance;
    }

    private static Announcement instance;
}
