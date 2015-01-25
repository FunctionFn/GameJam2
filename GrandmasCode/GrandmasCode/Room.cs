public abstract class Room
{
    protected int capacity;
    protected int occupancy;

    public Room(int capacity)
    {
        this.capacity = capacity;
    }

    public bool enter()
    {
        bool returnValue = false;
        if (this.occupancy < this.capacity)
        {
            this.occupancy++;
            returnValue = true;
        }
        return returnValue;
    }

    public bool leave()
    {
        bool returnValue = false;
        if (this.occupancy > 0)
        {
            this.occupancy--;
            returnValue = true;
        }
        return returnValue;
    }
}

