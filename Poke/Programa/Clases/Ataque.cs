namespace Poke.Clases;

public class Ataque
{
    //constructor
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public double Efectividad { get; set; }
    public bool EsEspecial { get; set; }

    public Ataque(string nombre, string tipo, double efectividad, bool esEspecial)
    {
        Nombre = nombre;
        Tipo = tipo;
        Efectividad = efectividad;
        EsEspecial = esEspecial;
    }

    public bool esEspecial()
    {
        return esEspecial();
    }
}

/*   public double calcularDanio(double ataque, double defensa, double basePower)
   {
       double danio = ((2 * ataque/defensa) * basePower / 50) + 2;
       return danio * Efectividad;
   }
}
*/
