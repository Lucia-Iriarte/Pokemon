namespace Poke.Clases;

public class Juego
{
    //constructor
    public Pokemon PokemonJugador { get; set; }
    public Pokemon PokemonOponente { get; set; }
    public int TurnoActual { get; set; }

    public Juego(Pokemon pokemonJugador, Pokemon pokemonOponente)
    {
        PokemonJugador = pokemonJugador;
        PokemonOponente = pokemonOponente;
        TurnoActual = 1;
    }

    public JugarTurno(Ataque ataqueJugador, Ataque ataqueOponente)
    {
        
    }

    public CalcularDanio()
    {
        
    }

    public JuegoTerminado()
    {
        
    }
}