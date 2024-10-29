namespace Poke.Clases;

public class Player
{
    // Atributos privados
    private List<Pokemon> Pokemones;
    private Pokemon PokemonActual;
    public List<Items> Items;

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
    

    public bool GetItem(Items items)
    {
        if (Items.Contains(items))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //Metodo para obtener la info de todos los pokemones
    public void GetPokemonsInfo()
    {
        foreach (var pokemon in Pokemones)
        {
            Console.WriteLine(pokemon.Nombre);
            Console.WriteLine(pokemon.Hp);
        }
    }
    
    // Método para obtener el Pokémon actual
    public Pokemon getPokemonActual()
    {
        return PokemonActual;
    }

    public void RemoveItem(Items item)
    {
        Items.Remove(item);
    }
    // Método para seleccionar un Pokémon
    public void seleccionPokemon(Pokemon pokemon)
    {
    }
    
    // Metodos que cuestan turnos 

    // Método para cambiar el Pokémon actual por otro de la lista
    public void cambiarPokemon(Pokemon nuevoPokemon)
    {
    }

    // Método para atacar usando el Pokémon actual
    public void atacarPokemon(Pokemon enemigo, Attack ataque)
    {
        // Seleccionar ataque y atacar a un Pokémon
    }
    
    // Método para usar un item
    public void usarItem(Items item, Pokemon objetivo)
    {
        item.Usar(objetivo);
    }
}    