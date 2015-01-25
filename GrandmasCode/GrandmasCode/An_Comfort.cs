class An_Comfort : Announcement
{
    private An_Comfort()
        : base("Comfortday's a special day!", new Threshold(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0))
    {
    }

    public static Announcement getInstance()
    {
        if (instance == null)
        {
            instance = new An_Comfort();
        }
        return instance;
    }

    private static Announcement instance;
}
