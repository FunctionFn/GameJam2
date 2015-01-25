class NoRoom : Room
{
    private static NoRoom instance;

    private NoRoom()
        : base(Constants.POPULATION)
    {
    }

    public static NoRoom getInstance()
    {
        if (instance == null)
        {
            instance = new NoRoom();
        }
        return instance;
    }
}
