namespace Aplicacion;

public class Bicicletas : Vehiculos
{

    public int CantCambios;
    public Bicicletas(string patente, string marca, string modelo, int añoFabricacion, double precioBaseDiario, int cantCambios) : base(patente, Marca, modelo, añoFabricacion, precioBaseDiario)
    {
        CantCambios = cantCambios;
    }

    public int CotizacionDeAlquileresBicicletas(int cantDias) 
    {
        int precioTarifa = cantDias * 200;
        return precioTarifa;
    }
}