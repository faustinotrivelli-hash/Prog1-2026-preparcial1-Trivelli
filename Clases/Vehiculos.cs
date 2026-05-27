namespace Aplicacion;

public class Vehiculos
{
    public string Patente {get; set;}
    public string Marca {get; set;}
    public string Modelo {get; set;}
    public int AñoFabricacion {get; set;}
    public double PrecioBaseDiario {get; set;}


    public Vehiculos(string patente, string marca, string modelo, int añoFabricacion, double precioBaseDiario)
    {
       Patente = patente;
       Marca = marca;
       Modelo = modelo;
       AñoFabricacion = añoFabricacion;
       PrecioBaseDiario = precioBaseDiario;
    }
}