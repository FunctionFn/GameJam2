class An_Meds : Announcement
{
    private An_Meds()
        : base("Medsday's a special day!", new Threshold(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0))
    {
    }

    public static Announcement getInstance()
    {
        if (instance == null)
        {
            instance = new An_Meds();
        }
        return instance;
    }

    private static Announcement instance;
}
