public abstract class Announcement
{
    public enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    protected Announcement(string msg, Threshold t)
    {
        this.message = msg;
        this.bonus = t;
    }

    //----------------------
    public string message;
    public Threshold bonus;

}

