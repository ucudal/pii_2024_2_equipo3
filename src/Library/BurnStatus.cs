namespace Library;

public class BurnStatus:IStatus
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public void Apply(Pokemon target)
    {
        target.Hp = (int)(target.Hp - (target.Hp * 0.1));
    }

    public BurnStatus(string name)
    {
        this.Name = name;
    }
}