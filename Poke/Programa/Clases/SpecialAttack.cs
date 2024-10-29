namespace Poke.Clases;

public class SpecialAttack : Attack
{
    public enum EfectoEspecial
    {
        Ninguno,
        Dormir,
        Paralizar,
        Envenenar,
        Quemar
    }
    
    public SpecialAttack (string nombre, int daño, string tipo, EfectoEspecial efecto)
    {
        this.Nombre = nombre;
        this.Daño = daño;
        this.Tipo = tipo;
        this.EsEspecial = true;
        this.EfectoEspecial = efecto;
        
        // sigo sin entender los errores
    }
    
    
}