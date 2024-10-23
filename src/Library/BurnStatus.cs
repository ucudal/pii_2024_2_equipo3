namespace Library;

public class BurnStatus: Status
{
    public override void Apply(Pokemon target)
    {
        target.Hp = (int)(target.Hp - (target.MaxHp * 0.1));
    }

    public BurnStatus()
    {
        this.EndOfTurn = true;
    }
}