using System.Collections;

namespace Library;

public class Pokemon
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    ////////////////stats//////////////////////////////

    private int maxhp;
    public int MaxHp
    {
        get { return maxhp; }
        set { maxhp = value; }
    }

    private int defensestat;
    public int DefenseStat
    {
        get { return defensestat; }
        set { defensestat = value; }
    }

    private int attackstat;
    public int AttackStat
    {
        get { return attackstat; }
        set { attackstat = value; }
    }

    
    ////////////////////////////////////////////////////
  
 
  ////////////////types and moveset (moves)(attacks)////////////////////
 
  
    private type type1;
    public type Type1
    {
        get { return type1; }
        set { type1 = value; }
    }

    private type type2;
    public type Type2
    {
        get { return type2; }
        set { type2 = value; }
    }

    private List<Move> moveset;
    public List<Move> Moveset
    {
        get { return moveset; }
        set { moveset = value; }
    }
    

    /// ///////////////////////////////////////////////

    //////////constructor////////////////
   
    public Pokemon(string name, int maxhp, type type1, type type2, Move move1, Move move2, Move move3, Move move4)
    {
        
        this.Name = name;
        this.MaxHp = maxhp;
        if (type1 != null)
        {
            this.Type1 = type1;
        }
        this.Type2 = type2;

        this.Moveset.Add(move1);
        this.Moveset.Add(move2);
        this.Moveset.Add(move3);
        this.Moveset.Add(move4);
        int specialmoves = 0;
        foreach (Move move in this.Moveset)
        {
            if (move.IsSpecial)
            {
                specialmoves = specialmoves + 1;
            }
        }

        if (specialmoves >= 2)
        {
            this.Moveset.Clear();
        }
        
    }
    
    //////////////////////////////////////
    
    ////////metodos//////////////////////

    public void Attack(Pokemon target, Move move)
    {
        target.ReceiveAttack(this,move);
    }

    public void ReceiveAttack(Pokemon attacker, Move move)
    {
        int initialDamage;
        //logica del daño (una re transa)


    }


}
