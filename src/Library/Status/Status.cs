namespace Library;

public abstract class Status
{
    public bool EndOfTurn { get; set; }
    public abstract void Apply(Pokemon target);
    private void Remove(Pokemon target)
    {
        target.Status = null;
    }
    
}