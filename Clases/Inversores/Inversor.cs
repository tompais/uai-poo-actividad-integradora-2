using uai_poo_actividad_integradora_2.Clases.Acciones;
using uai_poo_actividad_integradora_2.Clases.Inversiones;

namespace uai_poo_actividad_integradora_2.Clases.Inversores
{
    public class Inversor(uint legajo, string apellido, string nombre, uint dni) : IDisposable
    {
        public readonly uint Legajo = legajo;
        public readonly List<Inversion> Inversiones = [];

        public string Nombre { get; set; } = nombre;
        public string Apellido { get; set; } = apellido;
        public uint DNI { get; set; } = dni;

        ~Inversor()
        {
            Dispose();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public virtual TipoInversor ObtenerTipo() => TipoInversor.NORMAL;

        public void AgregarInversion(in Accion accion)
        {
            var inversion = new Inversion(accion);
            SuscribirseAEventoDeCambioDeCotización(in inversion);
            Inversiones.Add(inversion);

        }

        private void SuscribirseAEventoDeCambioDeCotización(in Inversion inversion) => inversion.Accion.CotizacionCambiada += Accion_CotizacionCambiada;

        private void Accion_CotizacionCambiada(object? sender, Accion.CotizacionCambiadaEventArgs e)
        {
            if (sender is Accion accion)
            {
                MessageBox.Show($"La acción {accion.Codigo} ha cambiado su cotización a {e.NuevaCotizacion}", "Cotización actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
