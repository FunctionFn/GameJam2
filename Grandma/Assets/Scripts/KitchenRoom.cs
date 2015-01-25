class KitchenRoom : Room
{
    private static KitchenRoom instance;

    private KitchenRoom()
        : base(Constants.KITCHEN_CAPACITY)
    {
    }

    public static KitchenRoom getInstance()
    {
        if (instance == null)
        {
            instance = new KitchenRoom();
        }
        return instance;
    }
}