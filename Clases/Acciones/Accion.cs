namespace uai_poo_actividad_integradora_2.Clases.Acciones
{
    public class Accion(string codigo, Denominacion denominacion, decimal cotizacionActual, uint cantidadEmitida) : IDisposable
    {
        public readonly string Codigo = codigo;
        public Denominacion Denominacion { get; set; } = denominacion;
        private decimal cotizacionActual = cotizacionActual;
        public decimal CotizacionActual
        {
            get => cotizacionActual;
            set
            {
                if (cotizacionActual != value)
                {
                    cotizacionActual = value;
                    CotizacionCambiada?.Invoke(this, new CotizacionCambiadaEventArgs(cotizacionActual));
                }
            }
        }
        public uint CantidadEmitida { get; set; } = cantidadEmitida;

        ~Accion()
        {
            Dispose();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        // Evento y argumentos personalizados
        public class CotizacionCambiadaEventArgs(decimal nuevaCotizacion) : EventArgs
        {
            public readonly decimal NuevaCotizacion = nuevaCotizacion;
        }

        public event EventHandler<CotizacionCambiadaEventArgs>? CotizacionCambiada;
    }
}
