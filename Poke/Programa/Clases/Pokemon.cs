using Poke.Clases;

namespace Poke.Clases;

public class  Pokemon
{
    private string nombre;
    private int hp;
    private Type tipo;
    private List<string> listaDeAtaques;
    public string Nombre { get; set; }
    private int capacidadDeAtacar;
    public int Hp { get; set; }
    public Type Tipo { get; set; }
    public int Ataque { get; set; }
    public List<Attack> ListaDeAtaques { get; set; }
    
    // Estados causados por ataques especiales
    public int? EstadoDormido { get; set; }  // Cantidad de turnos dormido, null si no está dormido
    
    public bool Paralizado { get; set; }
    public bool Envenenado { get; set; }
    public bool Quemado { get; set; }
    
    public Pokemon(string nombre, int salud, int ataque, int capacidadDeAtacar)
    {
        this.nombre = nombre;
        this.hp = salud;
        this.Ataque = ataque;
        this.capacidadDeAtacar = 1;
    }
    

    public string EstaVivo()
    {
        return null;
    }

    public void Atacar()
    {
        if (capacidadDeAtacar == 1)
        {
            // Atacar
        }
        else
        {
            Console.WriteLine($"{this.Nombre} no puede atacar en este turno ya que esta Paralizado");
        }
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
    
    // Métodos para actualizar estados en cada turno
    public void ActualizarEstado()
    {
        if (EstadoDormido.HasValue && EstadoDormido > 0)
        {
            EstadoDormido--;
            if (EstadoDormido == 0) EstadoDormido = null;
        }

        if (Envenenado) {
            RecibirDanio(Hp * 0.05);  // Pierde 5% del HP total si está envenenado
        }
        if (Quemado){
            RecibirDanio(Hp * 0.10);     // Pierde 10% del HP total si está quemado
        }

        if (Paralizado)
        {
            Random random = new Random();
            int capacidadDeAtacar = random.Next(0,2); // 0 o 1 definen si puede atacar
        }
    }
    
}