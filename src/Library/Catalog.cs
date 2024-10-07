using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Library;

public static class Catalog
{
    private static List<Pokemon> availablePokemon = new List<Pokemon>();

    public static List<Pokemon> AvailablePokemon
    {
        get { return availablePokemon; }
    }
    public static void AddPokemon(Pokemon pokemon)
    {
        AvailablePokemon.Add(pokemon);
    }
    
    public static void ShowList()
    {
        Console.WriteLine("Available Pokemon:");
        foreach (Pokemon pokemon in AvailablePokemon)
        {
            Console.WriteLine($"{pokemon.Name}");
        }
    }
    
}