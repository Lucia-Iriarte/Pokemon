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

    public string JugarTurno(Player jugador1, Player jugador2)
    {
        if (turno == 1)
        {
            // Turno del jugador 1
            // Seleccionar pokemon
            // Atacar
            // Cambiar de pokemon
            turno = 2; // Cambia de turno para que vaya el otro jugador
        }
        else
        {
            // Turno del jugador 2
            // Seleccionar pokemon
            // Atacar
            // Cambiar de pokemon
            turno = 1; // Idem que arriba
        }
        TurnoActual += 1;
        if (JuegoTerminado(jugador1, jugador2) == true)
        {
            return "Juego terminado";
        }
        else
        {
            return "Siguiente turno!";
        }
    }

    public void InfoTurno(Player jugador1, Player jugador2)
    {
        Console.WriteLine("Turno: " + TurnoActual);
        Console.WriteLine($"Información de los pokemones totales del juego:");
        jugador1.GetPokemonsInfo();
        jugador2.GetPokemonsInfo();
    }
    public bool JuegoTerminado(Player jugador1, Player jugador2)
    {
        jugador1.VidaPokemon();
        jugador2.VidaPokemon();
        if (jugador1.VidaPokemon() == 0)
        {
            Console.WriteLine("El jugador 2 ha ganado");
            return true;
        }
        else if (jugador2.VidaPokemon() == 0)
        {
            Console.WriteLine($"El jugador 1 ha ganado");
            return true;
        }
        else
        {
            return false;
        }
    }
}