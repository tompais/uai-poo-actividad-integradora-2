using uai_poo_actividad_integradora_2.Clases.Inversores;

namespace uai_poo_actividad_integradora_2.GUI.Formularios.Inversores
{
    public partial class FormularioAgregarInversor : Form
    {
        public Inversor Inversor { get; private set; } = null!;
        private readonly List<uint> DnisExistentes;
        public FormularioAgregarInversor(List<uint> dnisExistentes)
        {
            InitializeComponent();
            DnisExistentes = dnisExistentes;
            campoNumericoDNI.Controls[0].Hide();
        }

        private void ValidarInversorAAgregar(object sender, EventArgs e) => botonAgregar.Enabled = ValidarCampoApellido() &&
                                    ValidarCampoNombre() &&
                                    ValidarCampoDNI();

        private bool ValidarCampoDNI() => campoNumericoDNI.Value >= 1000000 &&
                   campoNumericoDNI.Value <= 99999999;

        private bool ValidarCampoNombre() => !string.IsNullOrWhiteSpace(campoDeTextoNombre.Text);

        private bool ValidarCampoApellido() => !string.IsNullOrWhiteSpace(campoDeTextoApellido.Text);

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            if (DnisExistentes.Contains((uint)campoNumericoDNI.Value))
            {
                MessageBox.Show("El DNI ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                campoNumericoDNI.Focus();
            }
            else
            {
                if (EsInversorNormalSeleccionado())
                {
                    Inversor = new Inversor((uint)new Random().Next(1, 1000000), campoDeTextoApellido.Text, campoDeTextoNombre.Text, (uint)campoNumericoDNI.Value);
                }
                else
                {
                    Inversor = new InversorPremium((uint)new Random().Next(1, 1000000), campoDeTextoApellido.Text, campoDeTextoNombre.Text, (uint)campoNumericoDNI.Value);
                }
                DialogResult = DialogResult.OK;
            }
        }

        private bool EsInversorNormalSeleccionado() => ValidarTipoInversorSeleccionado(out var tipoSeleccionado) && EsTipoInversorNormal(tipoSeleccionado);

        private static bool EsTipoInversorNormal(TipoInversor tipoInversor) => tipoInversor == TipoInversor.NORMAL;

        private bool ValidarTipoInversorSeleccionado(out TipoInversor tipoSeleccionado) => Enum.TryParse(selectorTipoInversor.SelectedItem?.ToString(), out tipoSeleccionado);

        private void FormularioAgregarInversor_Load(object sender, EventArgs e) => selectorTipoInversor.SelectedIndex = 0;
    }
}
