class PTRoom : Room
{
    private static PTRoom instance;

    private PTRoom()
        : base(Constants.PT_CAPACITY)
    {
    }

    public static PTRoom getInstance()
    {
        if (instance == null)
        {
            instance = new PTRoom();
        }
        return instance;
    }
}
