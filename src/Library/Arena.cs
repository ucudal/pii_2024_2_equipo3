namespace Library;

public class Arena
{

    //Pokemones en el campo de batalla
    private Pokemon Pokemon1;

    private Pokemon Pokemon2;

    //Jugadores en el campo de batalla
    private Player Jugador1;

    private Player Jugador2;

    public void creacionJugador1(string name1)
    {
        Player Player1 = new Player(name1);
        this.Jugador1 = Player1;
    }
    public void creacionJugador2(string name2)
    {
        Player Player2 = new Player(name2);
        this.Jugador2 = Player2;
    }

    //Configuraciones antes de iniciar los turnos
    public void PreBattle(Catalog pokemonCatalogue)
    {
        IOutput output = new Consola();
        //Creacion de jugadores
        creacionJugador1(output.crearNombre1());
        creacionJugador2(output.crearNombre2());

        //Seleccionar pokemones(usar catalogo)
        while (Jugador1.Team.Count + Jugador2.Team.Count < 12)
        {
            bool eligio = false;
            while (!eligio)
            {
                output.printSelectFromCatalog(Jugador1);
                output.showCatalogue(pokemonCatalogue);
                Pokemon seleccion = pokemonCatalogue.pickPokemon(output.printChoosePokemon());
                if (seleccion == null)
                {
                    output.printWrongName();
                }
                else
                {
                    Jugador1.SelectFromCatalog(seleccion);
                    eligio = true;
                }
            }

            bool eligio2 = false;
            while (!eligio2)
            {
                output.printSelectFromCatalog(Jugador2);
                output.showCatalogue(pokemonCatalogue);
                Pokemon seleccion = pokemonCatalogue.pickPokemon(output.printChoosePokemon());
                if (seleccion == null)
                {
                    output.printWrongName();
                }
                else
                {
                    Jugador2.SelectFromCatalog(seleccion);
                    eligio2 = true;
                }
            }
        }
        
        //Asignar pokemones para comenzar batalla
        sendPokemonToField(Jugador1);
        sendPokemonToField(Jugador2);
    }

    //Inicio de batalla por turnos
    public void Turns()
    {
        IOutput output = new Consola();
        int turno = 0;
        bool vivos = true;
        while (vivos)
        {

            //Turno actual
            output.printTurn(turno);

            output.printPokemonStatus(Pokemon1);
            output.printPokemonStatus(Pokemon2);

            //Acciones de jugador (agregar speed)
            if (Pokemon1.)
            accionDelJugador(Jugador1); // Usar valor bool para evitar accion del otro jugador
            
            turno += 1;
            vivos = checkIfAlive(Jugador1) && checkIfAlive(Jugador2); //Retorna false si uno de los dos equipos tiene todos sus pokemon derrotados
        }
    }


    private void sendPokemonToField(Player jugador)
    {
        Pokemon playersPokemon;
        if (jugador == Jugador1)
        {
            playersPokemon = Pokemon1;
        }
        else
        {
            playersPokemon = Pokemon2;
        }
        IOutput output = new Consola();
        bool eligio = false;
        while (eligio)
        {
            output.printSendToField(Jugador1); 
            foreach (Pokemon pokemon in Jugador1.Team) 
            { 
                output.printPokemonStatus(pokemon);
            }
            string pokemonName1 = output.getPokemonName(); 
            foreach (Pokemon pokemon in Jugador1.Team) 
            { 
                if (pokemonName1 == pokemon.Name) 
                { 
                    if (pokemon.Hp < 0) 
                    { 
                        output.printFainted(pokemon);
                    }
                    if (pokemon == playersPokemon) 
                    { 
                        output.printIsInField();
                    }
                    else 
                    { 
                        playersPokemon = pokemon;
                        if (jugador == Jugador1)
                        {
                            this.Pokemon1 = playersPokemon;
                        }
                        else
                        {
                            this.Pokemon2 = playersPokemon;
                        }
                        output.printPlayerChosePokemon(Jugador1, pokemon);
                        eligio = true;
                    }
                }
            }
        }
    }
    
    private bool attackPokemon(Player jugador) //Ataca y retorna true si el pokemon atacado es derrotado
    {
        Pokemon playersPokemon;
        if (jugador == Jugador1)
        {
            playersPokemon = Pokemon1;
        }
        else
        {
            playersPokemon = Pokemon2;
        }
        IOutput output = new Consola();
        string ataque = output.chooseAttack(playersPokemon);
        foreach (IMove movimiento in playersPokemon.Moveset) 
        { 
            if (movimiento.Name == ataque) 
            { 
                if (!movimiento.isOnCooldown()) 
                { 
                    if (jugador == Jugador1) 
                    { 
                        this.Pokemon1.Attack(Pokemon2, movimiento); 
                        movimiento.setCooldownTimer();
                        if (Pokemon2.Hp < 0) 
                        { 
                            output.printhasFainted(Pokemon2); 
                            return true;
                        }
                    }
                    else 
                    { 
                        this.Pokemon2.Attack(Pokemon1, movimiento); 
                        movimiento.setCooldownTimer();
                        if (Pokemon1.Hp < 0) 
                        { 
                            output.printhasFainted(Pokemon1); 
                            return true;
                        }
                    }
                }
            }
        }
        return false;
    }

    public bool accionDelJugador(Player jugador) //Retorna true si el otro jugador perdera el turno
    {
        IOutput output = new Consola();
        int accion = output.getAction(jugador);
        if (accion == 1)
        {
            return attackPokemon(jugador);
        }
        if (accion == 2)
        {
            sendPokemonToField(jugador);
        }
        foreach (Pokemon pokemon in jugador.Team) 
        { 
            foreach (IMove movimiento in pokemon.Moveset) 
            { 
                movimiento.reduceCooldownTimer();
            }
        }
        return false;
    }

    public bool checkIfAlive(Player jugador) //Retorna false si todo el equipo ha sido derrotado
    {
        IOutput output = new Consola();
        foreach (Pokemon pokemon in jugador.Team)
        {
            if (pokemon.Hp > 0)
            {
                return true;
            }
        }
        if (jugador == Jugador1)
        {
            output.printWonBattle(Jugador1, Jugador2);
        }
        else
        {
            output.printWonBattle(Jugador2, Jugador1);
        }
        return false;
    }
}