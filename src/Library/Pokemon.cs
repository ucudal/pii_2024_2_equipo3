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

    ////////////////stats///////////////////////////////////

    private int maxhp;
    public int MaxHp
    {
        get { return maxhp; }
        set { maxhp = value; }
    }
    
    private int hp;
    public int Hp
    {
        get { return hp; }
        set { hp = value; }
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
 
  
    private PokeType type1;
    public PokeType Type1
    {
        get { return type1; }
        set
        { type1 = value; }
    }

    private PokeType type2;
    public PokeType Type2
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
   
    public Pokemon(string name, int maxhp,int attackstat,int defensestat, PokeType type1, PokeType type2, Move move1, Move move2, Move move3, Move move4)
    {
        this.Moveset = [];
        this.Name = name;
        this.MaxHp = maxhp;
        this.AttackStat = attackstat;
        this.DefenseStat = defensestat;
        this.Hp = maxhp;
        this.Type1 = type1;
        this.Type2 = type2;
        this.Moveset.Add(move1);
        this.Moveset.Add(move2);
        this.Moveset.Add(move3);
        this.Moveset.Add(move4);
    }
    
    //////////////////////////////////////
    
    ////////metodos//////////////////////

    public void Attack(Pokemon target, Move move)
    {
        target.ReceiveAttack(this,move);
    }

    public void ReceiveAttack(Pokemon attacker, Move move)
    {
       
        int Damage;
        
        Damage = (attacker.AttackStat-this.DefenseStat+7) * (100 / move.Power);
        foreach (string immunity in this.Type1.Immunities)
        {
            if (immunity == move.MoveType.Name)
            {
                Damage = Damage * 0;
            }
        }

        if (this.Type2 != null)
        {


            foreach (string immunity in this.Type2.Immunities)
            {
                if (immunity == move.MoveType.Name)
                {
                    Damage = Damage * 0;
                }
            }
        }

        //    ^^ checks immunity for both types ^^  
        //    vv checks Resistances  vv
        foreach (string resistance in this.Type1.Resistances)
        {
            if (resistance == move.MoveType.Name)
            {
                Damage = Damage / 2;
            }
        }

        if (this.Type2 != null)
        {
            foreach (string resistance in this.Type2.Resistances)
            {
                if (resistance == move.MoveType.Name)
                {
                    Damage = Damage / 2;
                }
            }
        }

        //checks effectiveness
       foreach (string weakness in this.Type1.Weaknesses)
       {
           if (weakness == move.MoveType.Name)
           {
               Damage = Damage * 2;
           }
       }

       if (this.Type2 != null)
       {
           foreach (string weakness in this.Type2.Weaknesses)
           {
               if (weakness == move.MoveType.Name)
               {
                   Damage = Damage * 2;
               }
           }
       }

       Random rng = new Random();
       int chanceToFail = (100 - move.Accuracy);
       if (chanceToFail == 0)
       {this.Hp = this.Hp - Damage;}
       else if (rng.Next(1, 100) >= chanceToFail)
       {
           this.Hp = this.Hp - Damage;
       }
    }

    public string returnName()
    {
        return name;
    }


}
