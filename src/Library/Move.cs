using System.Text.RegularExpressions;

namespace Library;

public class Move
{

    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private type type1;

    public type Type1
    {
        get { return type1; }
        set { type1 = value; }
    }
    
    private bool isspecial;
    public bool IsSpecial
    {
        get { return isspecial; }
        set { isspecial = value; }
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

    public Move (string name,type type, int power, int accuracy)
    {
        this.Name = name;
        this.Type1 = type;
        this.Power = power;
        this.Accuracy = accuracy;
        
    }
    




}