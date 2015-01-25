class GardenRoom : Room
{
    private static GardenRoom instance;

    private GardenRoom()
        : base(Constants.GARDEN_CAPACITY)
    {
    }

    public static GardenRoom getInstance()
    {
        if (instance == null)
        {
            instance = new GardenRoom();
        }
        return instance;
    }
}
