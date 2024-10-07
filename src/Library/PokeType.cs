using System.Collections;
namespace Library;

public class PokeType
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private ArrayList weaknesses;
    public ArrayList Weaknesses
    {
        get { return weaknesses; }
        set { weaknesses = value; }
    }

    private ArrayList resistances;
    public ArrayList Resistances
    {
        get { return resistances; }
        set { resistances = value; }
    }
    
    private ArrayList immunities;

    public ArrayList Immunities
    {
        get { return immunities; }
        set { immunities = value; }
    }
    
    
    
    //constructor
    public PokeType(string name,ArrayList weaknesses, ArrayList resistances, ArrayList immunities)
    {
        this.Name = name;
        this.Weaknesses = weaknesses;
        this.Resistances = resistances;
        this.Immunities = immunities;
        
    }
    
    
    
}