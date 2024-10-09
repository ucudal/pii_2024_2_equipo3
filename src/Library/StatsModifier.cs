namespace Library;

public class StatsModifier:IMove
{
    private int cooldown;
    public int Cooldown
    {
        get { return cooldown; }
        set { cooldown = value; }
    }
    private int power;
    public int Power
    {
        get { return power; }
        set { power = value; }
    }
    private PokeType moveType;
    public PokeType MoveType
    {
        get { return moveType; }
        set { moveType = value; }
    }
    
    
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    private string targetStat;
    public string TargetStat
    {
        get { return targetStat; }
        set { targetStat = value; }
    }

    private double multiplier;
    public double Multiplier
    {
        get { return multiplier; }
        set { multiplier = value; }
    }

    private int accuracy;
    public int Accuracy
    {
        get { return accuracy; }
        set { accuracy = value; }
    }

    public StatsModifier(string name, string targetStat, double multiplier, int accuracy)
    {
        this.Name = name;
        this.TargetStat = targetStat;
        this.Multiplier = multiplier;
        this.Accuracy = accuracy;
    }
    public bool isOnCooldown()
    {
        return false;
    }

    public void reduceCooldownTimer()
    {
        
    }

    public void setCooldownTimer()
    {
        
    }
}