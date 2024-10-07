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

    private ArrayList team;

    public ArrayList Team
    {
        get { return team; }
        set { team = value; }
    }

    public Player(string name)
    {
        this.Name = name;
    }

    public string SelectPokemon(string pokemonName)
    {
        foreach (Pokemon pokemon in team)
        {
            if (pokemonName == pokemon.returnName())
            {
                return pokemonName;
            }
        }

        return null;
    }

    public string returnName()
    {
        return this.name;
    }

    public Pokemon getPokemonByName(string pokemonName)
    {
        foreach (Pokemon pokemon in team)
        {
            if (pokemon.returnName() == pokemonName)
            {
                return pokemon;
            }
        }

        return null;
    }
}