using uai_poo_actividad_integradora_2.Clases.Acciones;

namespace uai_poo_actividad_integradora_2.GUI.Formularios.Acciones.Modificar
{
    public partial class FormularioModificarAccion : Form
    {
        private readonly Accion Accion;
        public FormularioModificarAccion(in Accion accionAModificar)
        {
            InitializeComponent();
            Accion = accionAModificar;
        }

        private void FormularioModificarAccion_Load(object sender, EventArgs e)
        {
            campoNumericoCantidadEmitida.Controls[0].Hide();
            campoNumericoCotizacionActual.Controls[0].Hide();
            selectorDenominacion.SelectedIndex = (int)Accion.Denominacion;
            campoNumericoCotizacionActual.Value = Accion.CotizacionActual;
            campoNumericoCantidadEmitida.Value = Accion.CantidadEmitida;
        }

        private void ValidarAccionAModificar(object sender, EventArgs e) => botonModificarAccion.Enabled =
                            ValidarCampoCotizacionActual() &&
                            ValidarCampoCantidadEmitida();

        private bool ValidarCampoCantidadEmitida() => campoNumericoCantidadEmitida.Value >= 1 &&
                   campoNumericoCantidadEmitida.Value <= 1000000;

        private bool ValidarCampoCotizacionActual() => campoNumericoCotizacionActual.Value >= 100 && campoNumericoCotizacionActual.Value <= 1000000;

        private void BotonModificarAccion_Click(object sender, EventArgs e)
        {
            Accion.Denominacion = (Denominacion)selectorDenominacion.SelectedIndex;
            Accion.CotizacionActual = campoNumericoCotizacionActual.Value;
            Accion.CantidadEmitida = (uint)campoNumericoCantidadEmitida.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
