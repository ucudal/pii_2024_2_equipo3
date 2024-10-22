namespace Library;

public class ParalyzeStatus : IStatus
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public void Apply(Pokemon target)
    {
        foreach (IMove move in target.Moveset)
        {
            move.Accuracy = 50;             //hace que todos los ataques tengan en 50/50 de chances de fallar
        }                                   //simula la chance de poder o no atacar (cambiar despues para diferenciar)
    }

    public ParalyzeStatus(string name)
    {
        this.Name = name;
    }
}
