using System.Collections;

namespace Library;

public class Player
{

    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private List<Pokemon> team;

    public List<Pokemon> Team
    {
        get { return team; }
        set
        {
            team = value;
        }
    }

    public Player(string name)
    {
        this.Name = name;
    }
///////////Methods////////////

    public void SelectFromCatalog(Pokemon pokemon)
    {
        if (!Team.Contains(pokemon) && Team.Count < 6)
        {
            Team.Add(pokemon);
            //remove from catalog
        }
    }

    public Pokemon getPokemonByName(string pokemonName)
    {
        foreach (Pokemon pokemon in team)
        {
            if (pokemon.Name == pokemonName)
            {
                return pokemon;
            }
        }
        return null;
    }
    
}