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

///////////Methods////////////

    public void SelectFromCatalog(Pokemon pokemon)
    {
        if (!Team.Contains(pokemon) && Team.Count < 6)
        {
            Team.Add(pokemon);
        }
    }
    
}