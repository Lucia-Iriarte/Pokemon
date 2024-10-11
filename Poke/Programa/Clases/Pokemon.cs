using Poke.Iterfaces;

namespace Poke.Clases;

public class  Pokemon : IPokemon
{

    public string Name { get; set; }
    public int HP { get; set; }
    
    public string Type { get; set; }
    public int Ataque { get; set; }
    
    private List<string> ListaDeAtaques = new List<string>();
    
    public Pokemon(string nombre, int salud, int ataque)
    {
        Name = nombre;
        HP = salud;
        Ataque = ataque;
    }

    public string EstaVivo()
    {
        if (this.HP > 0)
        {
            return $"Tu pokemon {this.Name} esta vivo!";
        }
        return $"Tu pokemon {this.Name} esta muerto!";
    }

    public void Atacar()
    {
        // Metodo para atacar
    }

    public void RecibirDanio()
    {
        // Metodo para reducir la vida del pokemon cuando es atacado
    }

    public void AddAtaque(string nuevoAtaque)
    {
        ListaDeAtaques.Add(nuevoAtaque);
    }
}