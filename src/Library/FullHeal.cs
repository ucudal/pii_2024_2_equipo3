namespace Library;

public class FullHeal :Item
{
    //cura al pokemon de su status
    
    public override void Use(Pokemon target)
    {
        if (target.Status != null)
        {
            target.Status = null;
        }
    }
    
    
    
}