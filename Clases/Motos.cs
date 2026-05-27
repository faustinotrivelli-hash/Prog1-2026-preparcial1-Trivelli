namespace Apliacion;

public class Motos : Vehiculos
{
    public int TipoMoto;

    public Motos(string patente, string marca, string modelo, int añoFabricacion, double precioBaseDiario, int tipoMoto) : base(patente, marca, modelo, añoFabricacion, precioBaseDiario) {

        TipoMoto = tipoMoto;
    }

    public double CotizacionDeAlquileresMotos(double precioBaseDiario, int tipoMoto) 
    {
        double precioFinal = 0.0;
        switch (tipoMoto)
        {
            case 1:
                precioFinal = precioBaseDiario + (precioBaseDirio* 0.60);
                break;
            case 2: 
                precioFinal = precioBaseDiario + (precioBaseDirio* 0.60);
                break;
            case 3:
                precioFinal = precioBaseDiario + (precioBaseDirio* 0.80);
                break;
        }

        return precioFinal;
    }
}
