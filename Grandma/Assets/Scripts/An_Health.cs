class An_Health : Announcement
{
    private An_Health()
        : base("Healthday's a special day!", new Threshold(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0))
    {
    }

    public static Announcement getInstance()
    {
        if (instance == null)
        {
            instance = new An_Health();
        }
        return instance;
    }

    private static Announcement instance;
}
