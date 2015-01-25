class BedroomRoom : Room
{
    private static BedroomRoom instance;

    private BedroomRoom()
        : base(Constants.BEDROOM_CAPACITY)
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