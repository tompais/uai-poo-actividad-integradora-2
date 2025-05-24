using uai_poo_actividad_integradora_2.Clases.Acciones;
using uai_poo_actividad_integradora_2.Utilidades.Acciones;

namespace uai_poo_actividad_integradora_2.GUI.Formularios.Acciones.Agregar
{
    public partial class FormularioAgregarAccion : Form
    {
        public Accion Accion { get; private set; } = null!;
        private readonly List<string> CodigosAccionesExistentes;
        public FormularioAgregarAccion(List<string> codigosAccionesExistentes)
        {
            InitializeComponent();
            CodigosAccionesExistentes = codigosAccionesExistentes;
        }

        private void FormularioAgregarAccion_Load(object sender, EventArgs e)
        {
            selectorDenominacion.SelectedIndex = 0;
            campoNumericoCantidadEmitida.Controls[0].Hide();
            campoNumericoCotizacionActual.Controls[0].Hide();
        }

        private void ValidarAccionAAgregar(object sender, EventArgs e) => botonAgregarAccion.Enabled =
                                    ValidarCampoCotizacionActual() &&
                                    ValidarCampoCantidadEmitida() &&
                                    ValidarCampoCodigo();

        private bool ValidarCampoCodigo() => !string.IsNullOrWhiteSpace(campoDeTextoEnmascaradoCodigo.Text) && campoDeTextoEnmascaradoCodigo.Text.ValidarCodigoAccion();

        private bool ValidarCampoCantidadEmitida() => campoNumericoCantidadEmitida.Value >= 1 &&
                   campoNumericoCantidadEmitida.Value <= 1000000;

        private bool ValidarCampoCotizacionActual() => campoNumericoCotizacionActual.Value >= 100 && campoNumericoCotizacionActual.Value <= 1000000;

        private void BotonAgregarAccion_Click(object sender, EventArgs e)
        {
            if (CodigosAccionesExistentes.Contains(campoDeTextoEnmascaradoCodigo.Text))
            {
                MessageBox.Show("El código de la acción ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var codigo = campoDeTextoEnmascaradoCodigo.Text;
                var denominacion = (Denominacion)selectorDenominacion.SelectedIndex;
                var cotizacionActual = campoNumericoCotizacionActual.Value;
                var cantidadEmitida = (uint)campoNumericoCantidadEmitida.Value;
                Accion = new Accion(codigo, denominacion, cotizacionActual, cantidadEmitida);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
