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
Move Pound = new Move("Pound", Normal, 45, 100);
/////////////////MOVIMIENTOS/ATAQUES//////////////////////////////////////////////////////////////////////


/////////////////////STATUS///////////////////////////////////////////////////////////////////////////////
Status sPoison = new Status("Poison");
Status sBurn = new Status("Burn");
Status sSleep = new Status("Sleep");
Status sParalyze = new Status("Paralyze");
/////////////////////STATUS///////////////////////////////////////////////////////////////////////////////


/////////////////ATAQUES ESPECIALES///////////////////////////////////////////////////////////////////////
SpecialMove WillOWisp = new SpecialMove("Will-O-wisp", sBurn);
SpecialMove Toxic = new SpecialMove("Toxic", sPoison);
SpecialMove Spore = new SpecialMove("Spore", sSleep);
SpecialMove StunSpore = new SpecialMove("Stun Spore", sParalyze);
/////////////////ATAQUES ESPECIALES///////////////////////////////////////////////////////////////////////


///////////////////////MODIFICADORES////////////////////////////////////////////////////////////////////
StatsModifier SwordsDance = new StatsModifier("Swords Dance(+)", "Attack", 1.25, 80);
StatsModifier IronDefense = new StatsModifier("Iron Defense(+)", "Defense", 1.25, 80);
StatsModifier Agility = new StatsModifier("Agility(+)", "Speed", 1.25, 80);
StatsModifier Growl = new StatsModifier("Growl(-)", "Attack", 0.75, 80);
StatsModifier Leer = new StatsModifier("Leer(-)", "Defense", 0.75, 80);    //(+) o (-) indican si el efecto es de aumento o de reduccion de estadisticas
StatsModifier StringShot = new StatsModifier("String Shot(-)", "Speed", 0.75, 80);
///////////////////////MODIFICADORES////////////////////////////////////////////////////////////////////


///////////////////////POKEMONES/////////////////////////////////////////////////////////////////////////
Pokemon Charizard = Catalog.Instance.AddPokemon("Charizard", 100,75,52,11, Fire, Flying, Ember,Gust,WillOWisp,SwordsDance);
Pokemon Venusaur = Catalog.Instance.AddPokemon("Venusaur", 120,60,58,4, Grass, Poison, Leafage,PoisonSting , Spore, Growl);
Pokemon Blastoise = Catalog.Instance.AddPokemon("Blastoise", 110, 63, 55,8, Water, null, WaterGun, IronTail, Bite, Scratch);
Pokemon Pikachu = Catalog.Instance.AddPokemon("Pikachu", 105, 70, 50,25, Electric, null, Spark, IronTail, StunSpore, Leer);
Pokemon Butterfree = Catalog.Instance.AddPokemon("Butterfree", 100, 65, 52,22, Flying, Bug,Gust,BugBite,PoisonSting,StringShot);
Pokemon Pidgeot = Catalog.Instance.AddPokemon("Pidgeot", 105, 69, 53,21, Normal, Flying, Gust,WillOWisp,Pound,SwordsDance);
Pokemon Sandslash = Catalog.Instance.AddPokemon("Sandslash", 112, 63, 53,12, Ground, null,MudSlap,Toxic,LowSweep,Leer);
Pokemon Clefable = Catalog.Instance.AddPokemon("Clefable", 115, 61, 57, 10,Fairy, null,DisarmingVoice,Confusion,Spore,StringShot);
Pokemon Poliwrath = Catalog.Instance.AddPokemon("Poliwrath", 107, 73, 55,7, Water, Fighting,WaterGun,LowSweep,Toxic,Agility);
Pokemon Alakazam = Catalog.Instance.AddPokemon("Alakazam", 100, 77, 50,18, Psychic, null,Confusion,Pound,StunSpore,SwordsDance);
Pokemon Lapras = Catalog.Instance.AddPokemon("Lapras",110,67,54,15,Water,Ice,WaterGun,IceShard,Toxic,Agility);
Pokemon Gengar = Catalog.Instance.AddPokemon("Gengar",106,63,55,14,Ghost,Poison,PoisonSting,Lick,Toxic,StringShot);
Pokemon Onix = Catalog.Instance.AddPokemon("Onix",120,61,59,3,Rock,Ground,RockThrow,MudSlap,IronTail,StunSpore);
Pokemon Haxorus = Catalog.Instance.AddPokemon("Haxorus",110,77,55,19,Dragon,null,Twister,Bite,WillOWisp,SwordsDance);
Pokemon Sableye = Catalog.Instance.AddPokemon("Sableye",100,65,55,17,Ghost,Dark,Lick,Bite,WillOWisp,Leer);
Pokemon Corviknight = Catalog.Instance.AddPokemon("Corviknight",115,64,58,13,Flying,Steel,Gust,IronTail,StunSpore,IronDefense);
Pokemon Mawile = Catalog.Instance.AddPokemon("Mawile",106,65,55,5,Steel,Fairy,IronTail,DisarmingVoice,WillOWisp,IronDefense);
Pokemon Breloom = Catalog.Instance.AddPokemon("Breloom",105,75,53,20,Grass,Fighting,Leafage,LowSweep,Spore,Agility);
Pokemon Galvantula = Catalog.Instance.AddPokemon("Galvantula",110,68,55,23,Bug,Electric,BugBite,Spark,StunSpore,StringShot);
Pokemon Delphox = Catalog.Instance.AddPokemon("Delphox",107,74,55,9,Fire,Psychic,Ember,Confusion,WillOWisp,Growl);
Pokemon Snorlax = Catalog.Instance.AddPokemon("Snorlax", 120, 62, 59, 1,Normal, null, Pound, Confusion, StunSpore, Growl);
Pokemon Raikou = Catalog.Instance.AddPokemon("Raikou", 110, 76, 55, 24,Electric, null, Spark, IceShard, StunSpore, SwordsDance);
Pokemon Nidoking = Catalog.Instance.AddPokemon("Nidoking", 115, 64, 55, 6,Poison, Ground, PoisonSting, MudSlap, Toxic, Agility);
Pokemon Aggron = Catalog.Instance.AddPokemon("Aggron", 120, 60, 60, 2,Steel, Rock, IronTail, RockThrow, StunSpore, IronDefense);
Pokemon Chandelure = Catalog.Instance.AddPokemon("Chandelure", 113, 74, 56, 16, Ghost, Fire,Ember, Lick, WillOWisp, SwordsDance);
///////////////////////POKEMONES/////////////////////////////////////////////////////////////////////////


Arena Batalla = new Arena();
Batalla.PreBattle(Catalog.Instance);
Batalla.Turns();