class An_Comfort : Announcement
{
    private An_Comfort()
        : base("It's important to be comfortable,\nTake time to relax today!", new Threshold(0, 0, 0, 0, 0, 0, 15, 15, 0, 0, 0, 0))
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
