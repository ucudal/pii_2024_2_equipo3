namespace Library;

public class PoisonStatus: IStatus
{

    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    private void Apply(Pokemon target)
    {
        target.Hp = (int)(target.Hp - (target.Hp * 0.1));
    }

    private void Remove(Pokemon target)
    {
        target.Status = null;
    }

    public PoisonStatus(string name)
    {
        this.Name = name;
    }
    
    
    
    
}