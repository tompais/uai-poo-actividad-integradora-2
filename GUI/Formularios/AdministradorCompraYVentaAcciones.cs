using uai_poo_actividad_integradora_2.Clases.Inversores;
using uai_poo_actividad_integradora_2.GUI.Formularios.Inversores;

namespace uai_poo_actividad_integradora_2
{
    // ([A-Z]{4})+-([0-9]{4})+-([A-Z]{1})([0-9]{1})([A-Z]{1})([0-9]{1})
    public partial class AdministradorCompraYVentaAcciones : Form
    {
        private readonly List<Inversor> Inversores = [];
        public AdministradorCompraYVentaAcciones()
        {
            InitializeComponent();
        }

        private void BotonAgregarInversor_Click(object sender, EventArgs e)
        {
            var dnisExistentes = ObtenerDnisExistentes();
            var formularioAgregarInversor = new FormularioAgregarInversor(dnisExistentes);

            if (formularioAgregarInversor.ShowDialog() == DialogResult.OK)
            {
                var nuevoInversor = formularioAgregarInversor.Inversor;
                AgregarInversorALista(in nuevoInversor);
                AgregarInversorAGrilla(in nuevoInversor);
                MessageBox.Show($"Inversor agregado: {nuevoInversor.Nombre} {nuevoInversor.Apellido}", "Inversor Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private List<uint> ObtenerDnisExistentes() => [.. Inversores.Select(i => i.DNI)];

        private void AgregarInversorAGrilla(in Inversor nuevoInversor) => grillaInversores.Rows.Add(nuevoInversor.Legajo, nuevoInversor.Apellido, nuevoInversor.Nombre, nuevoInversor.DNI, nuevoInversor.ObtenerTipo());

        private void AgregarInversorALista(in Inversor nuevoInversor) => Inversores.Add(nuevoInversor);

        private void BotonEliminarInversor_Click(object sender, EventArgs e)
        {
            if (HayFilasSeleccionadas())
            {
                var inversorAEliminar = ObtenerInversorSeleccionado();
                if (inversorAEliminar != null)
                {
                    EliminarInversorDeLista(inversorAEliminar);
                    EliminarInversorDeGrilla();
                    MessageBox.Show($"Inversor eliminado: {inversorAEliminar.Nombre} {inversorAEliminar.Apellido}", "Inversor Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void EliminarInversorDeGrilla() => grillaInversores.Rows.Remove(ObtenerFilaSeleccionada());

        private void EliminarInversorDeLista(Inversor inversorAEliminar) => Inversores.Remove(inversorAEliminar);

        private Inversor? ObtenerInversorSeleccionado()
        {
            var legajo = ObtenerLegajoDeFilaSeleccionada();
            return Inversores.FirstOrDefault(i => i.Legajo == legajo);
        }

        private uint ObtenerLegajoDeFilaSeleccionada() => (uint)ObtenerFilaSeleccionada().Cells[0].Value;

        private DataGridViewRow ObtenerFilaSeleccionada() => grillaInversores.SelectedRows[0];

        private void GrillaInversores_SelectionChanged(object sender, EventArgs e) => botonModificarInversor.Enabled = botonEliminarInversor.Enabled = HayFilasSeleccionadas();

        private bool HayFilasSeleccionadas() => grillaInversores.SelectedRows.Count > 0;

        private void BotonModificarInversor_Click(object sender, EventArgs e)
        {
            if (HayFilasSeleccionadas())
            {
                var inversorAModificar = ObtenerInversorSeleccionado();
                if (inversorAModificar != null)
                {
                    var formularioModificarInversor = new FormularioModificarInversor(in inversorAModificar, ObtenerDnisExistentes());
                    if (formularioModificarInversor.ShowDialog() == DialogResult.OK)
                    {
                        var inversorModificado = formularioModificarInversor.Inversor;
                        ModificarInversorEnLista(in inversorAModificar, in inversorModificado);
                        ModificarInversorEnGrilla(in inversorModificado);
                        MessageBox.Show($"Inversor modificado: {inversorAModificar.Nombre} {inversorAModificar.Apellido}", "Inversor Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void ModificarInversorEnLista(in Inversor inversorAModificar, in Inversor inversorModificado)
        {
            var indice = Inversores.IndexOf(inversorAModificar);
            if (indice != -1)
            {
                Inversores[indice] = inversorModificado;
            }
        }

        private void ModificarInversorEnGrilla(in Inversor inversor)
        {
            var filaSeleccionada = ObtenerFilaSeleccionada();
            filaSeleccionada.Cells[0].Value = inversor.Legajo;
            filaSeleccionada.Cells[1].Value = inversor.Apellido;
            filaSeleccionada.Cells[2].Value = inversor.Nombre;
            filaSeleccionada.Cells[3].Value = inversor.DNI;
            filaSeleccionada.Cells[4].Value = inversor.ObtenerTipo();
        }
    }
}
