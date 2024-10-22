using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Library;

public class Pokemon
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private bool isalive;

    public bool IsAlive
    {
        get { return isalive; }
        set { isalive = value; }
    }

    private IStatus status;

    public IStatus Status
    {
        get { return status; }
        set { status = value; }
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

    private int speed;
    public int Speed
    {
        get { return speed; }
        set { speed = value; }
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

    private List<IMove> moveset;
    public List<IMove> Moveset
    {
        get { return moveset; }
        set { moveset = value; }
    }
    ///////////////////////////////////////////////////

    //////////constructor/////////////////////////////
   
    public Pokemon(string name, int maxhp,int attackstat,int defensestat,int speed, PokeType type1, PokeType type2, IMove move1, IMove move2, IMove move3, IMove move4)
    {
        this.Moveset = [];
        this.Name = name;
        this.IsAlive = true;
        this.MaxHp = maxhp;
        this.AttackStat = attackstat;
        this.DefenseStat = defensestat;
        this.Speed = speed;
        this.Hp = maxhp;
        this.Type1 = type1;
        this.Type2 = type2;
        this.Moveset.Add(move1);
        this.Moveset.Add(move2);
        this.Moveset.Add(move3);
        this.Moveset.Add(move4);
        this.Status = null;
    }
    
    //////////////////////////////////////
    
    ////////metodos//////////////////////

    public void Attack(Pokemon target, IMove move)
    {
        if (move is StatsModifier statsModifier)
        {
            target.Use(statsModifier,this);
        }
        else
        {
            target.ReceiveAttack(this,move);
        }
    }

    public void ReceiveAttack(Pokemon attacker, IMove move)
    {
        foreach (IMove attackermove in attacker.Moveset)
        {
            if (attackermove == move)
            {
                int Damage;
        
                Damage = (attacker.AttackStat-this.DefenseStat+7) * (100 / move.Power);
             if (Damage <= 0)
                {
                   Damage = 5;                   //para evitar daños negativos que terminan curando al rival
                }
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
               Random rngstatus = new Random();
               if (rng.Next(1, 100) < move.Accuracy)
               {
                   this.Hp = this.Hp - Damage;
               }
               
               
               if (this.Hp <= 0)
               {
                   this.Hp = 0;
                   this.Die();
               }
            }
        }
    }
       
        

    public void Use(StatsModifier statsModifier,Pokemon target)
    {
        Random rng = new Random();
        int Rng = rng.Next(1, 100);
        if (Rng < statsModifier.Accuracy)
        {
            if (statsModifier.TargetStat == "Attack")
            {
                target.AttackStat = (int)(target.AttackStat * statsModifier.Multiplier) ;
            }
            else if (statsModifier.TargetStat == "Defense")
            {
                target.DefenseStat = (int)(target.DefenseStat * statsModifier.Multiplier);
            }
            else if (statsModifier.TargetStat == "Speed")
            {
                target.Speed = (int)(target.Speed * statsModifier.Multiplier);
            }
        }
    }
     
    public void Die()
    {
        this.IsAlive = false;
        Console.WriteLine($"{this.Name} died!");
    }

}
