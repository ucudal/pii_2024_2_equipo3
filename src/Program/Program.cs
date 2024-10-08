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
Move Ember = new Move("Ember", Fire, 40, 100);
Move Leafage = new Move("Absorb",Grass, 40, 100);
Move WaterGun = new Move("Water Gun", Water, 40, 100);
Move Scratch = new Move("Scratch", Normal, 35, 100);
Move Spark = new Move("Spark", Electric, 40, 100);
Move Gust = new Move("Gust", Flying, 45, 100);
Move MudSlap = new Move("Mud Slap", Ground, 40, 100);
Move IronTail = new Move("Iron Tail", Steel, 45, 100);
Move PoisonSting = new Move("Poison Sting", Poison, 35, 100);
Move BugBite = new Move("Bug Bite", Bug, 40, 100);
Move Twister = new Move("Twister", Dragon, 45, 100);
Move DisarmingVoice = new Move("Disarming Voice", Fairy, 40, 100);
Move Confusion = new Move("Confusion", Psychic, 45, 100);
Move LowSweep = new Move("Low Sweep", Fighting, 45, 100);
Move Bite = new Move("Bite", Dark, 40, 100);
Move IceShard = new Move("Ice Shard",Ice, 40, 100);
Move Lick = new Move("Lick", Ghost, 40, 100);
Move RockThrow = new Move("Rock Throw", Rock, 40, 100);
/////////////////MOVIMIENTOS/ATAQUES//////////////////////////////////////////////////////////////////////




///////////////////////POKEMONES/////////////////////////////////////////////////////////////////////////
Pokemon Charizard = Catalog.Instance.AddPokemon("Charizard", 100,75,52, Fire, Flying, Ember,Gust,Twister,Scratch);
Pokemon Venusaur = Catalog.Instance.AddPokemon("Venusaur", 120,60,58, Grass, Poison, Leafage,PoisonSting , MudSlap, Scratch);
Pokemon Blastoise = Catalog.Instance.AddPokemon("Blastoise", 110, 63, 55, Water, null, WaterGun, IronTail, Bite, Scratch);
Pokemon Pikachu = Catalog.Instance.AddPokemon("Pikachu", 105, 70, 50, Electric, null, Spark, IronTail, Scratch, Scratch);
Pokemon Butterfree = Catalog.Instance.AddPokemon("Butterfree", 100, 65, 52, Flying, Bug,Gust,BugBite,PoisonSting,Scratch);
Pokemon Pidgeot = Catalog.Instance.AddPokemon("Pidgeot", 105, 69, 53, Normal, Flying, Gust,Twister,Bite,Scratch);
Pokemon Sandslash = Catalog.Instance.AddPokemon("Sandslash", 112, 63, 53, Ground, null,MudSlap,IronTail,LowSweep,Scratch );
Pokemon Clefable = Catalog.Instance.AddPokemon("Clefable", 115, 61, 57, Fairy, null,DisarmingVoice,Confusion,Lick,Scratch);
Pokemon Poliwrath = Catalog.Instance.AddPokemon("Poliwrath", 107, 73, 55, Water, Fighting,WaterGun,LowSweep,MudSlap,Scratch);
Pokemon Alakazam = Catalog.Instance.AddPokemon("Alakazam", 100, 77, 50, Psychic, null,Confusion,DisarmingVoice,Lick,Scratch);
Pokemon Lapras = Catalog.Instance.AddPokemon("Lapras",110,67,54,Water,Ice,WaterGun,IceShard,RockThrow,Scratch);
Pokemon Gengar = Catalog.Instance.AddPokemon("Gengar",106,63,55,Ghost,Poison,PoisonSting,Lick,Bite,Scratch);
Pokemon Onix = Catalog.Instance.AddPokemon("Onix",120,61,59,Rock,Ground,RockThrow,MudSlap,IronTail,Scratch);
Pokemon Haxorus = Catalog.Instance.AddPokemon("Haxorus",110,77,55,Dragon,null,Twister,Bite,LowSweep,Scratch);
Pokemon Sableye = Catalog.Instance.AddPokemon("Sableye",100,65,55,Ghost,Dark,Lick,Bite,Confusion,Scratch);
Pokemon Corviknight = Catalog.Instance.AddPokemon("Corviknight",115,64,57,Flying,Steel,Gust,IronTail,Ember,Scratch);
Pokemon Mawile = Catalog.Instance.AddPokemon("Mawile",106,65,55,Steel,Fairy,IronTail,DisarmingVoice,Bite,Scratch);
Pokemon Breloom = Catalog.Instance.AddPokemon("Breloom",105,75,53,Grass,Fighting,Leafage,LowSweep,PoisonSting,Scratch);
Pokemon Galvantula = Catalog.Instance.AddPokemon("Galvantula",110,68,55,Bug,Electric,BugBite,Spark,Bite,Scratch);
Pokemon Delphox = Catalog.Instance.AddPokemon("Delphox",107,74,55,Fire,Psychic,Ember,Confusion,Lick,Scratch);
///////////////////////POKEMONES/////////////////////////////////////////////////////////////////////////



Catalog.Instance.ShowList();

Charizard.Attack(Venusaur,Ember);
Venusaur.Attack(Blastoise,Leafage);
Blastoise.Attack(Charizard,WaterGun);
Pikachu.Attack(Blastoise,Spark);

Console.WriteLine($"Vs {Venusaur.Hp}");
Console.WriteLine($"Bl  {Blastoise.Hp}");
Console.WriteLine($"Ch  {Charizard.Hp}");