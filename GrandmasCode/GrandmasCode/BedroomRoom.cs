class BedroomRoom : Room
{
    private static BedroomRoom instance;

    private BedroomRoom()
        : base(Constants.POPULATION)
    {
    }

    public static BedroomRoom getInstance()
    {
        if (instance == null)
        {
            instance = new BedroomRoom();
        }
        return instance;
    }
}