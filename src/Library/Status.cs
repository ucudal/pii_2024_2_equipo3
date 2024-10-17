namespace Library;

public class Status
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Status(string name)
    {
        this.Name = name;
    }
}