namespace Library;

public class SuperPotion :Item
{
    //cura 70 de vida al pokemon
    
    public override void Use(Pokemon target)
    {
        target.Hp = target.Hp + 70;
        if (target.Hp > target.MaxHp)
        {
            target.Hp = target.MaxHp;
        }
    }
}