using uai_poo_actividad_integradora_2.Clases.Acciones;

namespace uai_poo_actividad_integradora_2.Clases.Inversiones
{
    public class Inversion(Accion accion)
    {
        public readonly Accion Accion = accion;
        public uint Cantidad { get; set; } = 1;

        public decimal CalcularValorTotalDeLaInversion() => Accion.CotizacionActual * Cantidad;
    }

}
