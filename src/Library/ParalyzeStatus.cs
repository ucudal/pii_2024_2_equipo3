namespace Library;

public class ParalyzeStatus : Status
{

    public override void Apply(Pokemon target)
    {
        
    }
  

    public ParalyzeStatus()
    {
        this.EndOfTurn = false;
    }
}
