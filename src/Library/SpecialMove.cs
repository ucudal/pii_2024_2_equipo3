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
    
    
    ///////constructor/////////

    public SpecialMove(string name, IStatus status)
    {
        this.Name = name;
        this.MoveType = null;
        this.Power = 0;
        this.Accuracy = 75;
        this.Cooldown = 1;
        this.CooldownTimer = 0;
    }

    public bool isOnCooldown()
    {
        if (CooldownTimer == 0)
        {
            return false;
        }
        else return true;
    }

    public void reduceCooldownTimer()
    {
        if (this.CooldownTimer > 0)
        {
            this.CooldownTimer = this.CooldownTimer - 1;
        }
    }

    public void setCooldownTimer()
    {
        this.CooldownTimer = this.Cooldown;
    }
    
}