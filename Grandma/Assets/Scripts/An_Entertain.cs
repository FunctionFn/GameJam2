class An_Entertain : Announcement
{
    private An_Entertain()
        : base("Feeling restless? Get some fun into\nyour day our in the garden!", new Threshold(0, 0, 0, 0, 15, 15, 0, 0, 0, 0, 0, 0))
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
