namespace uai_poo_actividad_integradora_2.Clases.Inversores
{
    public class InversorPremium(uint legajo, string nombre, string apellido, uint dni) : Inversor(legajo, nombre, apellido, dni)
    {
        ~InversorPremium()
        {
            Dispose();
            MessageBox.Show($"Inversor {Nombre} {Apellido} eliminado", "Inversor Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public override TipoInversor ObtenerTipo() => TipoInversor.PREMIUM;
    }
}
