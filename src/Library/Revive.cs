namespace Library;

public class Revive : Item
{
    //revive al pokemon seleccionado

    public override void Use(Pokemon target)
    {
        if (!(target.IsAlive))
        {
            target.IsAlive = true;
            Console.WriteLine($"Has revivido a {target.Name}!");
        }
        else
        {
            Console.WriteLine($"{target.Name} ya esta vivo...");
        }
    }


}