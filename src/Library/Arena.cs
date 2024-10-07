namespace Library;

public class Arena
{

    //Pokemones en el campo de batalla
    private Pokemon Pokemon1;

    private Pokemon Pokemon2;

    //Jugadores en el campo de batalla
    private Player Jugador1;

    private Player Jugador2;

    //Configuraciones antes de iniciar los turnos
    public void PreBattle()
    {
        //Creacion de jugadores
        Console.WriteLine("Ingrese nombre de jugador 1");
        string nombre1 = Console.ReadLine();
        Player Player1 = new Player(nombre1);
        this.Jugador1 = Player1;

        Console.WriteLine("Ingrese nombre de juagaor 2");
        string nombre2 = Console.ReadLine();
        Player Player2 = new Player(nombre2);
        this.Jugador2 = Player2;

        //Seleccionar pokemones(usar catalogo)

        //Asignar pokemones para comenzar batalla
        Console.WriteLine($"{Player1.Name} Seleccione pokemon para iniciar la batalla");
        string pokemonName1 = Console.ReadLine();
        this.Pokemon1 = Player1.getPokemonByName(pokemonName1);

        Console.WriteLine($"{Player2.Name} Seleccione pokemon para iniciar la batalla");
        string pokemonName2 = Console.ReadLine();
        this.Pokemon1 = Player2.getPokemonByName(pokemonName2);
    }

    //Inicio de batalla por turnos
    public void Turns()
    {
        int turno = 0;
        bool vivos = true;
        while (vivos)
        {
            //Turno actual
            Console.WriteLine($"Turno {turno}");
            Console.WriteLine();
            
            //Accion de jugador 1
            bool chose = false;
            bool actuo = false;
            while (!actuo)
            {
                Console.WriteLine($"{Jugador1.Name} para atacar ingrese(A), para cambiar pokemon ingrese(C)");
                string accion = Console.ReadLine();
                if (accion == "A")
                {
                    while (!chose)
                    {
                        Console.WriteLine("Eliga un ataque");
                        foreach (IMove movimiento in Pokemon1.Moveset)
                        {
                            Console.WriteLine($"{movimiento.Name}");
                        }
                        Console.WriteLine("Ingrese ataque: ");
                        string ataque = Console.ReadLine();
                        foreach (IMove movimiento in Pokemon1.Moveset)
                        {
                            if (movimiento.Name == ataque)
                            {
                                if (movimiento.Cooldown != 0)
                                {
                                    if (!movimiento.isOnCooldown())
                                    {
                                        this.Pokemon1.Attack(Pokemon2, movimiento);
                                        movimiento.setCooldownTimer();
                                        actuo = true;
                                    }
                                }
                                if (movimiento.Cooldown == 0)
                                {
                                    this.Pokemon1.Attack(Pokemon2, movimiento);
                                    actuo = true;
                                }
                                chose = true; 
                            } 
                        }
                        if (!chose)
                        {
                            Console.WriteLine("Movimiento incorrecto");
                        }
                    }
                }
                if (accion == "C")
                {
                    while (!chose)
                    {
                        Console.WriteLine("Eliga un pokemon para cambiar");
                        foreach (Pokemon pokemon in Jugador1.Team)
                        {
                            Console.WriteLine($"{pokemon.Name}");
                        }
                        Console.WriteLine("Ingrese nombre de pokemon");
                        string pokemonName = Console.ReadLine();
                        foreach (Pokemon pokemon in Jugador1.Team)
                        {
                            if (pokemonName == pokemon.Name)
                            {
                                if (pokemon.Hp == 0)
                                {
                                    Console.WriteLine("El pokemon seleccionado esta muerto");
                                }
                                if (pokemon == Pokemon1)
                                {
                                    Console.WriteLine("El pokemon seleccionado ya esta en el campo");
                                }
                                else
                                {
                                    this.Pokemon1 = pokemon;
                                    chose = true;
                                    actuo = true;
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("La accion ingresada es incorrecta");
                }
            }
            foreach (Pokemon pokemon in Jugador1.Team)
            {
                foreach (IMove movimiento in pokemon.Moveset)
                {
                    movimiento.reduceCooldownTimer();
                }
            }
            
            //Accion del Jugador 2
            bool chose2 = false;
            bool actuo2 = false;
            while (!actuo2)
            {
                Console.WriteLine($"{Jugador2.Name} para atacar ingrese(A), para cambiar pokemon ingrese(C)");
                string accion2 = Console.ReadLine();
                if (accion2 == "A")
                {
                    while (!chose2)
                    {
                        Console.WriteLine("Eliga un ataque");
                        foreach (IMove movimiento in Pokemon2.Moveset)
                        { 
                            Console.WriteLine($"{movimiento.Name}");
                        }
                        Console.WriteLine("Ingrese ataque: ");
                        string ataque = Console.ReadLine();
                        foreach (IMove movimiento in Pokemon2.Moveset)
                        {
                            if (movimiento.Name == ataque)
                            {
                                if (movimiento.Cooldown != 0)
                                {
                                    if (!movimiento.isOnCooldown())
                                    {
                                        this.Pokemon2.Attack(Pokemon1, movimiento);
                                        movimiento.setCooldownTimer();
                                    }
                                }

                                if (movimiento.Cooldown == 0)
                                {
                                    this.Pokemon2.Attack(Pokemon1, movimiento);
                                }
                                chose2 = true;
                                actuo2 = true;
                            }
                        }

                        if (!chose2)
                        {
                            Console.WriteLine("Movimiento incorrecto");
                        }
                    }
                }
                if (accion2 == "C")
                {
                    while (!chose2)
                    {
                        Console.WriteLine("Eliga un pokemon para cambiar");
                        foreach (Pokemon pokemon in Jugador2.Team)
                        {
                            Console.WriteLine($"{pokemon.Name}");
                        }
                        Console.WriteLine("Ingrese nombre de pokemon");
                        string pokemonName = Console.ReadLine();
                        foreach (Pokemon pokemon in Jugador2.Team)
                        {
                            if (pokemonName == pokemon.Name)
                            {
                                if (pokemon.Hp == 0)
                                {
                                    Console.WriteLine("El pokemon seleccionado esta muerto");
                                }
                                if (pokemon == Pokemon2)
                                {
                                    Console.WriteLine("El pokemon seleccionado ya esta en el campo");
                                }
                                else
                                {
                                    this.Pokemon2 = pokemon;
                                    chose2 = true;
                                    actuo2 = true;
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("La accion ingresada es incorrecta");
                }
            }
            foreach (Pokemon pokemon in Jugador2.Team)
            {
                foreach (IMove movimiento in pokemon.Moveset)
                {
                    movimiento.reduceCooldownTimer();
                }
            } 
            turno = turno + 1;
        }
    }
}