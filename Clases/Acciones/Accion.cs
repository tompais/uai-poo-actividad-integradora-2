namespace uai_poo_actividad_integradora_2.Clases.Acciones
{
    public class Accion(string codigo, Denominacion denominacion, decimal cotizacionActual, uint cantidadEmitida) : IDisposable
    {
        public readonly string Codigo = codigo;
        public Denominacion Denominacion { get; set; } = denominacion;
        public decimal CotizacionActual { get; set; } = cotizacionActual;
        public uint CantidadEmitida { get; set; } = cantidadEmitida;

        ~Accion()
        {
            Dispose();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
