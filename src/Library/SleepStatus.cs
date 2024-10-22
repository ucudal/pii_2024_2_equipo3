namespace Library;

public class SleepStatus:IStatus
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    public void Apply(Pokemon target)
    {
        Random rng = new Random();
        int TurnsAsleep = rng.Next(1, 4);
        foreach (IMove move in target.Moveset)
        {
            move.Cooldown = TurnsAsleep;
        }
    }

    public SleepStatus(string name)
    {
        this.Name = name;
    }
}