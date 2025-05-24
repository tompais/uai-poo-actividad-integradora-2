namespace uai_poo_actividad_integradora_2.Clases.Inversores
{
    public class Inversor(uint legajo, string apellido, string nombre, uint dni) : IDisposable
    {
        public readonly uint Legajo = legajo;
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
    }
}
