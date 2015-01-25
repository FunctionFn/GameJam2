class An_Health : Announcement
{
    private An_Health()
        : base("We can's forget the importance of\nfitness, let's keep active!", new Threshold(0, 0, 15, 15, 0, 0, 0, 0, 0, 0, 0, 0))
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
