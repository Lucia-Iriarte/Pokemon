namespace Poke.Clases;

public class Juego
{
    // Constructor
    public Pokemon PokemonJugador { get; set; }
    public Pokemon PokemonOponente { get; set; }
    public int TurnoActual { get; set; }

    public Juego(Pokemon pokemonJugador, Pokemon pokemonOponente)
    {
        PokemonJugador = pokemonJugador;
        PokemonOponente = pokemonOponente;
        TurnoActual = 1;
    }

    public void JugarTurno(Ataque ataqueJugador, Ataque ataqueOponente /* aclarar que se puede atacar
     y/o cambiar de pokemon en el turno, no solamente atacar */ )
    {
        // Metodo para atacar/recibir daño
        
        // Metodo para cambiar de pokemon
    }

    public string InfoTurno()
    {
        /*
         * El usuario deberia poder solicitar la informacion del turno, como por ejemplo
         * Ver el estado de los pokemones de los oponentes, el numero de turno que se esta jugando
         * No se toma como turno jugado
         */
        return "info";
    }
    public void JuegoTerminado()
    {
        // Verificar en cada ronda (o a partir de una especificada) si la vida de los 6 pokemones 
        // de cada jugador es 0; mientras no lo sea, el juego continua
    }
}