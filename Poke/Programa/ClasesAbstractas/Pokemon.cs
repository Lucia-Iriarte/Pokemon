using Poke.Clases;

namespace Poke.Clases;

public abstract class  Pokemon
{
    private string nombre;
    private int hp;
    private Type tipo;
    private List<string> listaDeAtaques;
    
    public string Nombre { get; set; }
    public int Hp { get; set; }
    public Type Tipo { get; set; }
    public int Ataque { get; set; }
    public List<Attack> ListaDeAtaques { get; set; }
    public Pokemon(string nombre, int salud, int ataque)
    {
    }
    

    public string EstaVivo()
    {
        return null;
    }

    public void Atacar()
    {
        // Metodo para atacar
    }

    public void AddAtaque(Attack nuevoAtaque)
    {
        if (ListaDeAtaques.Count < 4)
        {
            ListaDeAtaques.Add(nuevoAtaque);
        }
        else
        {
            Console.WriteLine("No se pueden agregar más ataques, el límite es 4");
        }
    }
    public void RecibirDanio(double danio)
    {
        // Metodo para reducir la vida del pokemon cuando es atacado
    }
    
    public void AddHP(int hp)
    {
        Hp += hp;
    }

    public List<Attack> GetAtaques()
    {
        return null;
    }

    public Type GetTipo()
    {
        return tipo;
    }

    public double GetHp()
    {
        return hp;
    }
    
}