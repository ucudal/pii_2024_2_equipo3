using System.Text;
using Library;

//////////////////TIPOS//////////////////////////////////////////////////////////////////////////////////
PokeType Normal = new PokeType("Normal", ["Fighting"], [], ["Ghost"]);
PokeType Fire = new PokeType("Fire", ["Ground","Water","Rock"], ["Grass","Fire","Ice","Bug","Steel","Fairy"],[]);
PokeType Water = new PokeType("Water",["Grass","Electric",],["Fire","Water","Ice","Steel"],[""]);
PokeType Grass = new PokeType("Grass", ["Fire","Ice","Poison","Flying","Bug"], ["Water","Grass","Electric","Ground"], []);
PokeType Electric = new PokeType("Electric", ["Ground"], ["Electric","Flying","Steel"], []);
PokeType Ice = new PokeType("Ice", ["Fire","Fighting","Rock","Steel"], ["Ice"], []);
PokeType Fighting = new PokeType("Fighting", ["Flying","Psychic","Fairy"], ["Bug","Rock","Dark"], []);
PokeType Poison = new PokeType("Poison", ["Ground","Psychic"], ["Grass","Fighting","Poison","Bug","Fairy"], []);
PokeType Ground = new PokeType("Ground", ["Water","Grass","Ice"], ["Poison","Rock"], ["Electric"]);
PokeType Flying = new PokeType("Flying", ["Electric","Ice","Rock"], ["Grass","Fighting","Bug"], ["Ground"]);
PokeType Psychic = new PokeType("Psychic", ["Bug","Ghost","Dark"], ["Fighting","Psychic"], []);
PokeType Bug = new PokeType("Bug", ["Fire","Flying","Rock"], ["Grass","Fighting","Ground"], []);
PokeType Rock = new PokeType("Rock", ["Water","Grass","Fighting","Ground","Steel"], ["Normal","Fire","Poison","Flying"], []);
PokeType Ghost = new PokeType("Ghost", ["Ghost","Dark"], ["Poison","Bug"], ["Normal","Fighting"]);
PokeType Dragon = new PokeType("Dragon", ["Ice","Dragon","Fairy"], ["Fire","Water","Grass","Electric",], []);
PokeType Dark = new PokeType("Dark", ["Fighting","Bug","Fairy"], ["Ghost","Dark"], ["Psychic"]);
PokeType Steel = new PokeType("Steel", ["Fire","Fighting","Ground"], ["Normal","Grass","Ice","Flying","Psychic","Bug","Rock","Dragon","Steel","Fairy"], ["Poison"]);
PokeType Fairy = new PokeType("Fairy", ["Poison","Steel"], ["Fighting","Bug","Dark"], ["Dragon"]);
//////////////////TIPOS//////////////////////////////////////////////////////////////////////////////////


/////////////////MOVIMIENTOS/ATAQUES//////////////////////////////////////////////////////////////////////
Move Ember = new Move("Ember", Fire, 45, 100);
Move Absorb = new Move("Absorb",Grass, 45, 100);
Move WaterGun = new Move("Water Gun", Water, 45, 100);
Move Scratch = new Move("Scratch", Normal, 35, 100);
Move Spark = new Move("Spark", Electric, 40, 100);
Move Peck = new Move("Peck", Flying, 45, 100);
Move MudSlap = new Move("Mud Slap", Ground, 40, 100);
Move IronTail = new Move("Iron Tail", Steel, 45, 100);
Move PoisonSting = new Move("Poison Sting", Poison, 35, 100);

/////////////////MOVIMIENTOS/ATAQUES//////////////////////////////////////////////////////////////////////


///////////////////////POKEMONES/////////////////////////////////////////////////////////////////////////
Catalog.Instance.AddPokemon("Charizard", 100,75,52, Fire, Flying, Ember,Ember,Scratch,Scratch);
Catalog.Instance.AddPokemon("Venusaur", 120,55,65, Grass, Poison, Absorb,Absorb , Scratch, Scratch);
Catalog.Instance.AddPokemon("Squirtle", 110, 60, 55, Water, null, WaterGun, WaterGun, Scratch, Scratch);
Catalog.Instance.AddPokemon("Pikachu", 105, 70, 50, Electric, null, Spark, IronTail, Scratch, Scratch);
Catalog.Instance.AddPokemon("Butterfree", 100, 65, 52, Flying, Bug,Peck,);
Catalog.Instance.AddPokemon("Pidgeot", 105, 69, 53, Normal, Flying, Peck,Scratch,);
Catalog.Instance.AddPokemon("Sandslash", 112, 61, 53, Ground, null,MudSlap,IronTail,Scratch,);
Catalog.Instance.AddPokemon("Clefable", 115, 55, 63, Fairy, null,);
Catalog.Instance.AddPokemon("Poliwrath", 107, 7, 55, Water, Fighting,);
Catalog.Instance.AddPokemon("Alakazam", 100, 77, 50, Psychic, null,);
///////////////////////POKEMONES/////////////////////////////////////////////////////////////////////////



Catalog.ShowList();


Charizard.Attack(Venusaur,Ember);
Venusaur.Attack(Blastoise,Absorb);
Blastoise.Attack(Charizard,WaterGun);
Pikachu.Attack(Blastoise,Spark);

Console.WriteLine($"Vs {Venusaur.Hp}");
Console.WriteLine($"Bl  {Blastoise.Hp}");
Console.WriteLine($"Ch  {Charizard.Hp}");