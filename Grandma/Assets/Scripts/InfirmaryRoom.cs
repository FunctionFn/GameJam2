class InfirmaryRoom : Room
{
    private static InfirmaryRoom instance;

    private InfirmaryRoom()
        : base(Constants.INFIRMARY_CAPACITY)
    {
    }

    public static InfirmaryRoom getInstance()
    {
        if (instance == null)
        {
            instance = new InfirmaryRoom();
        }
        return instance;
    }
}
