using Library;


    
type Fire = new type("Fire", ["Ground","Water","Rock"], ["Grass","Fire","Ice","Bug","Steel","Fairy"],[]);
type Water = new type("Water",["Grass","Electric",],["Fire","Water","Ice","Steel"],[]);
type Grass = new type("Grass", ["Fire","Ice","Poison","Flying","Bug"], ["Water","Grass","Electric","Ground"], []);

Console.WriteLine($"{Water.Name} is weak to: {Water.Weaknesses[0]}");
Console.WriteLine($"{Water.Name} resists {Water.Resistances[0]}-type attacks");





