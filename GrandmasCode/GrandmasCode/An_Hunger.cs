class An_Hunger : Announcement
{
    private An_Hunger()
        : base("Hungerday's a special day!", new Threshold(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0))
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
