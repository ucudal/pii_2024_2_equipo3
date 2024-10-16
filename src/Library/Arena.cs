using System;

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
        this.Pokemon1 = null;
        this.Pokemon2 = null;
        IOutput output = new Consola();
        //Creacion de jugadores
        creacionJugador1(output.crearNombre1());
        creacionJugador2(output.crearNombre2());

        //Seleccionar pokemones(usar catalogo)
        while (Jugador1.Team.Count + Jugador2.Team.Count < 4)
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

            //Acciones de jugador
            if (Pokemon1.Speed > Pokemon2.Speed)
            {
                bool players2action = accionDelJugador(Jugador1);
                if (!players2action)
                {
                    accionDelJugador(Jugador2);
                }
            }
            if(Pokemon2.Speed > Pokemon1.Speed)
            {
                bool players1action = accionDelJugador(Jugador2);
                if (!players1action)
                {
                    accionDelJugador(Jugador1);
                }
            }
            else
            {
                Random random = new Random();
                if (random.Next(1, 2) == 1)
                {
                    bool players2action = accionDelJugador(Jugador1);
                    if (!players2action)
                    {
                        accionDelJugador(Jugador2);
                    }
                }
                else
                { 
                    bool players1action = accionDelJugador(Jugador2);
                    if (!players1action) 
                    { 
                        accionDelJugador(Jugador1);
                    }
                }
                
            }
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
        while (!eligio)
        {
            output.printSendToField(jugador); 
            foreach (Pokemon pokemon in jugador.Team) 
            { 
                output.printPokemonStatus(pokemon);
            }
            string pokemonName1 = output.getPokemonName(); 
            foreach (Pokemon pokemon in jugador.Team) 
            { 
                if (pokemonName1 == pokemon.Name) 
                { 
                    if (pokemon.Hp <= 0) 
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
                        output.printPlayerChosePokemon(jugador, pokemon);
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
                Pokemon target = output.getTarget(jugador, Pokemon1, Pokemon2);
                if (!movimiento.isOnCooldown()) 
                { 
                    if (jugador == Jugador1) 
                    { 
                        playersPokemon.Attack(target, movimiento); 
                        movimiento.setCooldownTimer();
                        if (!checkIfAlive(Jugador2))
                        {
                            return true;
                        }
                        if (target.Hp <= 0)
                        { 
                            output.printhasFainted(target);
                            sendPokemonToField(Jugador2);
                            return true;
                        }
                    }
                    else 
                    { 
                        playersPokemon.Attack(target, movimiento); 
                        movimiento.setCooldownTimer();
                        if (!checkIfAlive(Jugador1))
                        {
                            return true;
                        }
                        if (Pokemon1.Hp <= 0) 
                        { 
                            output.printhasFainted(target);
                            sendPokemonToField(Jugador1);
                            return true;
                        }
                    }
                }
            }
        }
        output.printPokemonStatus(Pokemon1);
        output.printPokemonStatus(Pokemon2);
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
        output.printPokemonStatus(Pokemon1);
        output.printPokemonStatus(Pokemon2);
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
            output.printWonBattle(Jugador2, Jugador1);
        }
        else
        {
            output.printWonBattle(Jugador1, Jugador2);
        }
        return false;
    }
}