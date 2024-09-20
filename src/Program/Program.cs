using System.Text;
using Library;

type Normal = new type("Normal", [], [], []);
type Fire = new type("Fire", ["Ground","Water","Rock"], ["Grass","Fire","Ice","Bug","Steel","Fairy"],[]);
type Water = new type("Water",["Grass","Electric",],["Fire","Water","Ice","Steel"],[""]);
type Grass = new type("Grass", ["Fire","Ice","Poison","Flying","Bug"], ["Water","Grass","Electric","Ground"], []);
type No = new type("No", [], [], []);
Console.WriteLine($"{Water.Name} is weak to: {Water.Weaknesses[0]}");
Console.WriteLine($"{Water.Name} resists {Water.Resistances[0]}-type attacks");

Move Ember = new Move("Ember", Fire, 45, 100);
Move Absorb = new Move("Absorb",Grass, 45, 100);
Move WaterGun = new Move("Water Gun", Water, 45, 50);
Move Scratch = new Move("Scratch", Normal, 35, 100);


Pokemon Charmander = new Pokemon("Charmander", 100,75,52, Fire, No, Ember,Ember,Scratch,Scratch);
Pokemon Bulbasaur = new Pokemon("Bulbasaur", 120,55,65, Grass, No, Absorb,Absorb , Scratch, Scratch);
Pokemon Squirtle = new Pokemon("Squirtle", 110, 60, 53, Water, No, WaterGun, WaterGun, Scratch, Scratch);


Charmander.Attack(Bulbasaur,Ember);
Bulbasaur.Attack(Squirtle,Absorb);
Squirtle.Attack(Charmander,WaterGun);

Console.WriteLine($"Bbs {Bulbasaur.Hp}");
Console.WriteLine($"SQ  {Squirtle.Hp}");
Console.WriteLine($"Ch  {Charmander.Hp}");