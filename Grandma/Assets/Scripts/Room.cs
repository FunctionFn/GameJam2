public abstract class Room
{
    protected int capacity;
    protected int occupancy;

    public Room(int capacity)
    {
        this.capacity = capacity;
    }

    public bool canEnter()
    {
        return this.occupancy < this.capacity;
    }

    public bool canLeave()
    {
        return this.occupancy > 0;
    }

    public Room enter()
    {
        this.occupancy++;
        return this;
    }

    public void leave()
    {
        this.occupancy--;
    }
}

