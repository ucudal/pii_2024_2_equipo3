namespace Library;
public interface IMove
{
    
    
    //i like to move it move it
    public int Cooldown { set; get; }
    public string Name { set; get; }
    public PokeType MoveType { set; get; }
    
    public int Accuracy { set; get; }
    
    public int Power { set; get; }
}