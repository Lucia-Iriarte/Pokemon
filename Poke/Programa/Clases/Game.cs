namespace Poke.Clases;

public class Game
{
    private Pokemon pokemonJugador;
    private int turnoAleatorio { get; set; }
    private Pokemon pokemonOponente;

    private int turno;
    // Constructor
    public Pokemon PokemonJugador { get; set; }
    public Pokemon PokemonOponente { get; set; }
    public int TurnoActual { get; set; }

    public void jugadaInicial(Player jugador1, Player jugador2)
    {
        Random random = new Random();
        int primerTurno = random.Next(1, 3);
        if (primerTurno == 1)
        {
            turno = 1;
        }
        else
        {
            turno = 2;
        }
    }
    public Game(Pokemon pokemonJugador, Pokemon pokemonOponente)
    {
        PokemonJugador = pokemonJugador;
        PokemonOponente = pokemonOponente;
        TurnoActual = 1;
    }

    public void JugarTurno()
    {
        if (turno == 1)
        {
            // Turno del jugador 1
            // Seleccionar pokemon
            // Atacar
            // Cambiar de pokemon
            // Verificar si el juego ha terminado
            turno = 2;
            TurnoActual += 1;
        }
        else
        {
            // Turno del jugador 2
            // Seleccionar pokemon
            // Atacar
            // Cambiar de pokemon
            // Verificar si el juego ha terminado
            JuegoTerminado(Player jugador1, Player jugador2);
            turno = 1;
            TurnoActual += 1;
        }
    }

    public void InfoTurno(Player jugador1, Player jugador2)
    {
        Console.WriteLine("Turno: " + TurnoActual);
        Console.WriteLine($"Información de los pokemones totales del juego:");
        jugador1.GetPokemonsInfo();
        jugador2.GetPokemonsInfo();
    }
    public void JuegoTerminado(Player jugador1, Player jugador2)
    {
        jugador1.VidaPokemon();
        jugador2.VidaPokemon();
        if (jugador1.VidaPokemon() == 0)
        {
            Console.WriteLine("El jugador 2 ha ganado");
        }
        else if (jugador2.VidaPokemon() == 0)
        {
            Console.WriteLine($"El jugador 1 ha ganado");
        }
        else
        {
            
        }
    }
}