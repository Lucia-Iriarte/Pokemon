namespace Poke.Clases;

public abstract class Attack
{
    private string nombre;

    private int daño;

    private Type tipo;

    private bool esEspecial;
    
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public double Daño { get; set; }
    public bool EsEspecial { get; set; }

    public Attack (string nombre, int daño, Type tipo, bool esEspecial)
    {
        this.nombre = nombre;
        this.daño = daño;
        this.tipo = tipo;
        this.esEspecial = esEspecial;
    }
    
    public double? CalcularDanio(Pokemon atacante, Pokemon defensor)
    {
        return null;
    }
}

