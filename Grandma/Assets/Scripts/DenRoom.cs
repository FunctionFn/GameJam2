class DenRoom : Room
{
    private static DenRoom instance;

    private DenRoom()
        : base(Constants.DEN_CAPACITY)
    {
    }

    public static DenRoom getInstance()
    {
        if (instance == null)
        {
            instance = new DenRoom();
        }
        return instance;
    }
}
