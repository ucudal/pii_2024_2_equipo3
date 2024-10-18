namespace Library;

public class Status
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private int chanceToApply;

    public int ChanceToApply
    {
        get { return chanceToApply; }
        set { chanceToApply = value; }
    }
    public Status(string name)
    {
        this.Name = name;
    }
}