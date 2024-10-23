namespace Library;

public class SpecialMove: IMove
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private PokeType moveType;
    public PokeType MoveType
    {
        get { return moveType; }
        set { moveType = value; }
    }
    
    private int cooldown;
    public int Cooldown
    {
        get { return cooldown; }
        set { cooldown = value; }
    }

    private int cooldownTimer;

    public int CooldownTimer
    {
        get { return cooldownTimer; }
        set { cooldownTimer = value; }
    }
    
    private int accuracy;
    public int Accuracy
    {
        get { return accuracy; }
        set { accuracy = value; }
    }

    private int power;
    public int Power
    {
        get { return power; }
        set { power = value; }

    }

    public Status Status
    {
        get;
        set;
    }
    
    
    ///////constructor/////////

    public SpecialMove(string name, Status status)
    {
        this.Name = name;
        this.Accuracy = 75;
        this.Cooldown = 0;
        this.Status = status;
    }

 
    
}