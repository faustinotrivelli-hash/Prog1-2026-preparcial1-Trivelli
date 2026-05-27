namespace Aplicacion;

public class Autos : Vehiculos
{
    public Autos(string patente, string marca, string modelo, int añoFabricacion, double precioBaseDiario) : base(patente, marca, modelo, añoFabricacion, precioBaseDiario){}

    public double CotizacionDeAlquileresAutos(int cantDias, double precioBaseDiario, bool cobertura)
    {
        double precioFinal;

        if (cantDias > 7)
        {
            if (cobertura)
            {
                precioFinal = (precioBaseDiario - (precioBaseDiario*0.15)) + precioBaseDiario*0.10;

            } else {
                precioFinal = precioBaseDiario - (precioBaseDiario*0.15);
            }
        } else
        {
            if (cobertura)
            {
                precioFinal = precioBaseDiario * 0.10;
            } else
            {
                precioFinal = precioBaseDiario * cantDias;
            }
        }

        return precioFinal;
    }
}
