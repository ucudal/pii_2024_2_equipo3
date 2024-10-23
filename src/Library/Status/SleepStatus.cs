namespace Library;

public class SleepStatus: Status
{

    public override void Apply(Pokemon target)
    {
        
        Random rng = new Random();
        int TurnsAsleep = rng.Next(1, 4);
        foreach (IMove move in target.Moveset)
        {
            move.Cooldown = TurnsAsleep;
        }
    }

    public SleepStatus()
    {
        this.EndOfTurn = false;
    }
}