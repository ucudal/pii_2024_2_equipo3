namespace Library;

public interface IOutput
{
    public string crearNombre1();
    public string crearNombre2();
    public void showCatalogue(Catalog pokemonCatalog);
    public void printSelectFromCatalog(Player jugador);
    public string printChoosePokemon();
    public void printWrongName();
    public void printSendToField(Player jugador);
    public void printPokemonStatus(Pokemon pokemon);
    public string getPokemonName();
    public void printFainted(Pokemon pokemon);
    public void printIsInField();
    public void printPlayerChosePokemon(Player jugador, Pokemon pokemon);
    public void printTurn(int turno);
    public int getAction(Player jugador);
    public void printhasFainted(Pokemon pokemon);
    public string chooseAttack(Pokemon pokemon);
    public void printWonBattle(Player winner, Player loser);
}