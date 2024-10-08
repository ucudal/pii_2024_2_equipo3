using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Library;

public class Catalog
{
    private static Catalog instance;

    public static Catalog Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Catalog();
            }

            return instance;
        }
    }
    
    private List<Pokemon> pokemonCatalog;

    public IReadOnlyList<Pokemon> PokemonCatalog
    {
        get { return pokemonCatalog; }
    }

    private Catalog()
    {
        pokemonCatalog = new List<Pokemon>();
    }
  
    
    public void ShowList()
    {
        Console.WriteLine("Available Pokemon:");
        foreach (Pokemon pokemon in PokemonCatalog)
        {
            Console.WriteLine($"{pokemon.Name}");
        }
    }

    //Agregamos el metodo AddPokemon a catalog que llama al constructor de pokemon y lo agrega al catalogo
    public Pokemon AddPokemon(string name, int maxhp, int attackstat, int defensestat, PokeType type1, PokeType type2,
        IMove move1, IMove move2, IMove move3, IMove move4)
    {
        Pokemon pokemon = new Pokemon(name, maxhp, attackstat, defensestat, type1, type2, move1, move2, move3,
            move4);
        this.pokemonCatalog.Add(pokemon);
        return pokemon;
    }
}