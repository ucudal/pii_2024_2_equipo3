namespace Library;

public class Consola : IOutput
{
    public string crearNombre1()
    {
        Console.WriteLine("Ingrese nombre de jugador 1");
        string nombre1 = Console.ReadLine();
        return nombre1;
    }

    public string crearNombre2()
    {
        Console.WriteLine("Ingrese nombre de jugador 2");
        string nombre2 = Console.ReadLine();
        return nombre2;
    }

    public void showCatalogue(Catalog PokemonCatalog)
    {
        Console.WriteLine("Available Pokemon:");
        foreach (Pokemon pokemon in PokemonCatalog.PokemonCatalog)
        {
            if (pokemon.Type2 == null)
            {
                Console.WriteLine($"{pokemon.Name} | {pokemon.Type1.Name}");
            }
            else
            {
                Console.WriteLine($"{pokemon.Name} | {pokemon.Type1.Name}-{pokemon.Type2.Name}");
            }
        }
    }

    public void printSelectFromCatalog(Player jugador)
    {
        Console.WriteLine($"{jugador.Name} eliga un pokemon del catalogo");
    }

    public string printChoosePokemon()
    {
        Console.WriteLine("Ingrese nombre del pokemon que desea elegir");
        string pokemon = Console.ReadLine();
        return pokemon;
    }

    public void printWrongName()
    {
        Console.WriteLine("Nombre incorrecto");
    }

    public void printSendToField(Player jugador)
    {
        Console.WriteLine($"{jugador.Name} Seleccione un pokemon para enviar al campo");
    }

    public void printPokemonStatus(Pokemon pokemon)
    {
        Console.WriteLine($"{pokemon.Name} {pokemon.Hp}/{pokemon.MaxHp}");
    }

    public string getPokemonName()
    {
        Console.WriteLine("Ingrese nombre de pokemon");
        string pokemonName1 = Console.ReadLine();
        return pokemonName1;
    }

    public void printFainted(Pokemon pokemon)
    {
        Console.WriteLine($"{pokemon.Name} esta deshabilitado");
    }

    public void printIsInField()
    {
        Console.WriteLine("El pokemon seleccionado ya esta en el campo");
    }

    public void printPlayerChosePokemon(Player jugador, Pokemon pokemon)
    {
        Console.WriteLine($"{jugador.Name} ha elegido a {pokemon.Name}");
    }

    public void printTurn(int turno)
    {
        Console.WriteLine($"Turno {turno}");
    }

    public int getAction(Player jugador)
    {
        bool chose = false;
        Console.WriteLine($"{jugador.Name} para atacar ingrese(A), para cambiar pokemon ingrese(C)");
        while (!chose)
        {
            string accion = Console.ReadLine();
            if (accion == "A")
            {
                return 1;
            }
            if (accion == "C")
            {
                return 2;
            }
            Console.WriteLine("La accion ingresada es incorrecta");
        }
        return 0;
    }

    public void printhasFainted(Pokemon pokemon)
    {
        Console.WriteLine($"{pokemon.Name} ha sido derrotado"); 
    }

    public string chooseAttack(Pokemon pokemon)
    {
        Console.WriteLine("Eliga un ataque"); 
        foreach (IMove movimiento in pokemon.Moveset) 
        { 
            Console.WriteLine($"{movimiento.Name}");
        } 
        Console.WriteLine("Ingrese ataque: "); 
        string ataque = Console.ReadLine();
        return ataque;
    }

    public void printWonBattle(Player winner, Player loser)
    {
        Console.WriteLine($"!Felicidades {winner.Name}, has derrotado a {loser.Name}");
    }
}