public enum weekDays
{
	SUNDAY,
	MONDAY,
	TUESDAY,
	WEDNESDAY,
	THURSDAY,
	FRIDAY,
	SATURDAY
}

public abstract class Announcement
{
    protected Announcement(string msg, Threshold t)
    {
        this.message = msg;
        this.bonus = t;
    }

    //----------------------
    public string message;
    public Threshold bonus;

}

