namespace Library;

public class PoisonStatus: Status
{
    
    public override void Apply(Pokemon target)
    {
        target.Hp = (int)(target.Hp - (target.Hp * 0.05));
    }

   
    public PoisonStatus()
    {
        this.EndOfTurn = true;
    }
    
    
    
    
}