using uai_poo_actividad_integradora_2.Clases.Inversores;

namespace uai_poo_actividad_integradora_2.GUI.Formularios.Inversores
{
    public partial class FormularioModificarInversor : Form
    {
        public Inversor Inversor { get; private set; }
        private readonly List<uint> DnisExistentes;
        public FormularioModificarInversor(in Inversor inversorAModificar, List<uint> dnisExistentes)
        {
            InitializeComponent();
            campoNumericoDNI.Controls[0].Hide();
            Inversor = inversorAModificar;
            DnisExistentes = dnisExistentes;
        }

        private void ValidarInversorAModificar(object sender, EventArgs e) => botonAgregar.Enabled = ValidarCampoApellido() &&
                                    ValidarCampoNombre() &&
                                    ValidarCampoDNI();

        private bool ValidarCampoDNI() => campoNumericoDNI.Value >= 1000000 &&
                   campoNumericoDNI.Value <= 99999999;

        private bool ValidarCampoNombre() => !string.IsNullOrWhiteSpace(campoDeTextoNombre.Text);

        private bool ValidarCampoApellido() => !string.IsNullOrWhiteSpace(campoDeTextoApellido.Text);

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            if (DnisExistentes.Contains((uint)campoNumericoDNI.Value) && Inversor.DNI != (uint)campoNumericoDNI.Value)
            {
                MessageBox.Show("El DNI ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                campoNumericoDNI.Focus();
            }
            else
            {
                var tipoSeleccionado = (TipoInversor)selectorTipoInversor.SelectedIndex;

                if (EsTipoInversorDiferente(tipoSeleccionado))
                {
                    // Cambió el tipo: crear nueva instancia
                    if (EsTipoPremium(tipoSeleccionado))
                    {
                        Inversor = new InversorPremium(Inversor.Legajo, campoDeTextoApellido.Text, campoDeTextoNombre.Text, (uint)campoNumericoDNI.Value);
                    }
                    else
                    {
                        Inversor = new Inversor(Inversor.Legajo, campoDeTextoApellido.Text, campoDeTextoNombre.Text, (uint)campoNumericoDNI.Value);
                    }
                }
                else
                {
                    // No cambió el tipo: modificar el existente
                    Inversor.Apellido = campoDeTextoApellido.Text;
                    Inversor.Nombre = campoDeTextoNombre.Text;
                    Inversor.DNI = (uint)campoNumericoDNI.Value;
                }
                DialogResult = DialogResult.OK;
            }
        }

        private static bool EsTipoPremium(TipoInversor tipoSeleccionado) => tipoSeleccionado == TipoInversor.PREMIUM;

        private bool EsTipoInversorDiferente(TipoInversor tipoSeleccionado) => tipoSeleccionado != Inversor.ObtenerTipo();

        private void FormularioModificarInversor_Load(object sender, EventArgs e)
        {
            campoDeTextoNombre.Text = Inversor.Nombre;
            campoDeTextoApellido.Text = Inversor.Apellido;
            campoNumericoDNI.Value = Inversor.DNI;
            selectorTipoInversor.SelectedIndex = (int)Inversor.ObtenerTipo();
        }
    }
}
