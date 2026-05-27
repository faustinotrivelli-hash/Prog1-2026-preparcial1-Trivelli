namespace Aplicacion;

public class Reservas
{
    public int NumId {set;}
    public string NomCli {get; set;}
    public Vehiculos Vehiculo {get; set;}
    public int CantDias {get; set;}

    public Reservas(int numId, string nomCli, Vehiculos vehiculo, int cantDias)
    {
        NumId = numId;
        NomCli = nomCli;
        Vehiculo = vehiculo;
        CantDias = cantDias;
    }
}