using System.Text.RegularExpressions;

namespace Library;

public class Move: IMove
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

    private Status applicableStatus;

    public Status ApplicableStatus
    {
        get { return applicableStatus; }
        set { applicableStatus = value; }
    }

    private double statusChance;

    public double StatusChance
    {
        get { return statusChance; }
        set { statusChance = value; }
    }
    
    
    ///////constructor/////////
    public Move (string name,PokeType moveType, int power, int accuracy, Status status,double statusChance)
    {
        this.Name = name;
        this.MoveType = moveType;
        this.Power = power;
        this.Accuracy = accuracy;
        this.Cooldown = 0;
        this.ApplicableStatus = status;
        this.StatusChance = statusChance;
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