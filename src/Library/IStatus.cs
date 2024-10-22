namespace Library;

public interface IStatus
{
    public string Name { get; set; }
    private void Remove(Pokemon target)
    {
        target.Status = null;
    }

    
}