class An_Meds : Announcement
{
    private An_Meds()
        : base("Don't forget the doctor's orders!\nTake all your medications each day", new Threshold(0, 0, 0, 0, 0, 0, 0, 0, 15, 15, 0, 0))
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
