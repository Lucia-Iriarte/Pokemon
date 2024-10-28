namespace Poke.Clases;

public class Player
{
    // Atributos privados
    private List<Pokemon> Pokemones;
    private Pokemon PokemonActual;
    private List<Items> Items;

    // Constructor
    public Player()
    {
        Pokemones = new List<Pokemon>();
        this.PokemonActual = PokemonActual;
        
        Items = new List<Items>();
        // Agrego los items
        
        Items.Add(new SuperPocion());
        Items.Add(new SuperPocion());
        Items.Add(new SuperPocion());
        Items.Add(new SuperPocion());
        
        Items.Add(new CuraTotal());
        Items.Add(new CuraTotal());
        
        Items.Add(new RevivirPocion());
        
    }

    // Método para seleccionar un Pokémon
    public void seleccionPokemon(Pokemon pokemon)
    {
    }

    // Método para cambiar el Pokémon actual por otro de la lista
    public void cambiarPokemon(Pokemon nuevoPokemon)
    {
    }

    // Método para atacar usando el Pokémon actual
    public void atacarPokemon(Pokemon enemigo)
    {
    }

    // Método para obtener el Pokémon actual
    public Pokemon getPokemonActual()
    {
        return PokemonActual;
    }
}