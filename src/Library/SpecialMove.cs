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

    private bool available;

    public bool Available
    {
        get { return available;}
        set { available = value;}
    }
    
    ///////constructor/////////

    public SpecialMove(string name, PokeType moveType, int power, int accuracy)
    {
        this.Name = name;
        this.MoveType = moveType;
        this.Power = power;
        this.Accuracy = accuracy;
        Available = true;
        this.Cooldown = 0;
    }
}