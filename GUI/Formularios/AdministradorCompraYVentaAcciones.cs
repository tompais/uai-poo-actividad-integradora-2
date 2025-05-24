using uai_poo_actividad_integradora_2.Clases.Acciones;
using uai_poo_actividad_integradora_2.Clases.Inversiones;
using uai_poo_actividad_integradora_2.Clases.Inversores;
using uai_poo_actividad_integradora_2.GUI.Formularios.Acciones.Agregar;
using uai_poo_actividad_integradora_2.GUI.Formularios.Acciones.Modificar;
using uai_poo_actividad_integradora_2.GUI.Formularios.Inversores;

namespace uai_poo_actividad_integradora_2
{
    public partial class AdministradorCompraYVentaAcciones : Form
    {
        private readonly List<Inversor> Inversores = [];
        private readonly List<Accion> Acciones = [];
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
            if (HayFilasSeleccionadasEnGrillaInversores())
            {
                var inversorAEliminar = ObtenerInversorSeleccionado();
                if (inversorAEliminar != null)
                {
                    DevolverAccionesAlMercado(inversorAEliminar);
                    EliminarInversorDeLista(in inversorAEliminar);
                    EliminarInversorDeGrilla();
                    ActualizarGrillaAcciones();
                    ActualizarGrillaInversiones();
                    MessageBox.Show($"Inversor eliminado: {inversorAEliminar.Nombre} {inversorAEliminar.Apellido}", "Inversor Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ActualizarGrillaInversiones()
        {
            if (EsListaDeInversoresVacia() || NoHaySeleccionEnGrillaInversores())
            {
                grillaInversiones.Rows.Clear();
            }
            else
            {
                var inversorSeleccionado = ObtenerInversorSeleccionado();
                if (inversorSeleccionado != null)
                {
                    ActualizarGrillaInversiones(inversorSeleccionado);
                }
                else
                {
                    grillaInversiones.Rows.Clear();
                }
            }
        }

        private bool NoHaySeleccionEnGrillaInversores()
        {
            return grillaInversores.SelectedRows.Count == 0;
        }

        private bool EsListaDeInversoresVacia()
        {
            return Inversores.Count == 0;
        }

        private static void DevolverAccionesAlMercado(Inversor inversorAEliminar) => inversorAEliminar.Inversiones.ForEach(inversion => inversion.Accion.CantidadEmitida += inversion.Cantidad);

        private void EliminarInversorDeGrilla() => grillaInversores.Rows.Remove(ObtenerFilaSeleccionadaEnGrillaInversores());

        private void EliminarInversorDeLista(in Inversor inversorAEliminar) => Inversores.Remove(inversorAEliminar);

        private void ActualizarGrillaAcciones()
        {
            grillaAcciones.Rows.Clear();
            Acciones.ForEach(accion => AgregarAccionAGrilla(in accion));
        }

        private Inversor? ObtenerInversorSeleccionado()
        {
            var legajo = ObtenerLegajoDeFilaSeleccionada();
            return Inversores.FirstOrDefault(i => i.Legajo == legajo);
        }

        private uint ObtenerLegajoDeFilaSeleccionada() => (uint)ObtenerFilaSeleccionadaEnGrillaInversores().Cells[0].Value;

        private DataGridViewRow ObtenerFilaSeleccionadaEnGrillaInversores() => grillaInversores.SelectedRows[0];

        private void GrillaInversores_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotonesInversores();
            ActualizarEstadoBotonComprarAccion();
        }

        private void ActualizarEstadoBotonComprarAccion() => botonComprarAccion.Enabled = HayFilasSeleccionadasEnGrillaInversores() && HayFilasSeleccionadasEnGrillaAcciones();

        private void ActualizarEstadoBotonesInversores() => botonModificarInversor.Enabled = botonEliminarInversor.Enabled = HayFilasSeleccionadasEnGrillaInversores();

        private bool HayFilasSeleccionadasEnGrillaInversores() => grillaInversores.SelectedRows.Count > 0;

        private void BotonModificarInversor_Click(object sender, EventArgs e)
        {
            if (HayFilasSeleccionadasEnGrillaInversores())
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
            var filaSeleccionada = ObtenerFilaSeleccionadaEnGrillaInversores();
            filaSeleccionada.Cells[0].Value = inversor.Legajo;
            filaSeleccionada.Cells[1].Value = inversor.Apellido;
            filaSeleccionada.Cells[2].Value = inversor.Nombre;
            filaSeleccionada.Cells[3].Value = inversor.DNI;
            filaSeleccionada.Cells[4].Value = inversor.ObtenerTipo();
        }

        private void BotonAgregarAccion_Click(object sender, EventArgs e)
        {
            var formularioAgregarAccion = new FormularioAgregarAccion(ObtenerCodigosAccionesExistentes());
            if (formularioAgregarAccion.ShowDialog() == DialogResult.OK)
            {
                var nuevaAccion = formularioAgregarAccion.Accion;
                AgregarAccionALista(in nuevaAccion);
                AgregarAccionAGrilla(in nuevaAccion);
                MessageBox.Show($"Acción agregada: {nuevaAccion.Codigo}", "Acción Agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private List<string> ObtenerCodigosAccionesExistentes() => [.. Acciones.Select(a => a.Codigo)];

        private void AgregarAccionAGrilla(in Accion nuevaAccion) => grillaAcciones.Rows.Add(nuevaAccion.Codigo, nuevaAccion.Denominacion, nuevaAccion.CotizacionActual, nuevaAccion.CantidadEmitida);

        private void AgregarAccionALista(in Accion nuevaAccion) => Acciones.Add(nuevaAccion);

        private void GrillaAcciones_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotonesAcciones();
            ActualizarEstadoBotonComprarAccion();
        }

        private void ActualizarEstadoBotonesAcciones() => botonModificarAccion.Enabled = botonEliminarAccion.Enabled = HayFilasSeleccionadasEnGrillaAcciones();

        private bool HayFilasSeleccionadasEnGrillaAcciones() => grillaAcciones.SelectedRows.Count > 0;

        private void BotonEliminarAccion_Click(object sender, EventArgs e)
        {
            if (HayFilasSeleccionadasEnGrillaAcciones())
            {
                var accionAEliminar = ObtenerAccionSeleccionada();
                if (accionAEliminar != null)
                {
                    RemoverInversionesAsociadas(accionAEliminar);
                    EliminarAccionDeLista(in accionAEliminar);
                    EliminarAccionDeGrilla();
                    ActualizarGrillaInversiones();
                    MessageBox.Show($"Acción eliminada: {accionAEliminar.Codigo}", "Acción Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void RemoverInversionesAsociadas(Accion accion) => Inversores.ForEach(inversor => inversor.Inversiones.RemoveAll(inversion => inversion.Accion.Codigo == accion.Codigo));

        private void EliminarAccionDeGrilla()
        {
            var filaSeleccionada = ObtenerFilaSeleccionadaEnGrillaAcciones();
            if (filaSeleccionada != null)
            {
                grillaAcciones.Rows.Remove(filaSeleccionada);
            }
        }

        private void EliminarAccionDeLista(in Accion accionAEliminar)
        {
            var indice = Acciones.IndexOf(accionAEliminar);
            if (indice != -1)
            {
                Acciones.RemoveAt(indice);
            }
        }

        private Accion? ObtenerAccionSeleccionada()
        {
            var codigo = ObtenerCodigoDeFilaSeleccionada();
            return Acciones.FirstOrDefault(a => a.Codigo == codigo);
        }

        private string ObtenerCodigoDeFilaSeleccionada() => ObtenerFilaSeleccionadaEnGrillaAcciones().Cells[0].Value.ToString()!;

        private DataGridViewRow ObtenerFilaSeleccionadaEnGrillaAcciones() => grillaAcciones.SelectedRows[0];

        private void BotonModificarAccion_Click(object sender, EventArgs e)
        {
            if (HayFilasSeleccionadasEnGrillaAcciones())
            {
                var accionAModificar = ObtenerAccionSeleccionada();
                if (accionAModificar != null)
                {
                    var formularioModificarAccion = new FormularioModificarAccion(in accionAModificar);
                    if (formularioModificarAccion.ShowDialog() == DialogResult.OK)
                    {
                        ModificarAccionEnGrilla();
                        MessageBox.Show($"Acción modificada: {accionAModificar.Codigo}", "Acción Modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void ModificarAccionEnGrilla()
        {
            var filaSeleccionada = ObtenerFilaSeleccionadaEnGrillaAcciones();
            if (filaSeleccionada != null)
            {
                var accionModificada = ObtenerAccionSeleccionada();
                if (accionModificada != null)
                {
                    filaSeleccionada.Cells[0].Value = accionModificada.Codigo;
                    filaSeleccionada.Cells[1].Value = accionModificada.Denominacion;
                    filaSeleccionada.Cells[2].Value = accionModificada.CotizacionActual;
                    filaSeleccionada.Cells[3].Value = accionModificada.CantidadEmitida;
                }
            }
        }

        private void BotonComprarAccion_Click(object sender, EventArgs e)
        {
            if (HayFilasSeleccionadasEnGrillaInversores() && HayFilasSeleccionadasEnGrillaAcciones())
            {
                var inversorSeleccionado = ObtenerInversorSeleccionado();
                var accionSeleccionada = ObtenerAccionSeleccionada();
                if (inversorSeleccionado != null && accionSeleccionada != null)
                {
                    ReducirCantidadEmitida(in accionSeleccionada);
                    AsignarInversionAInversor(in inversorSeleccionado, in accionSeleccionada);
                    ModificarAccionEnGrilla();
                    ActualizarGrillaInversiones(inversorSeleccionado);
                    MessageBox.Show($"Compra realizada: {inversorSeleccionado.Nombre} {inversorSeleccionado.Apellido} compró {accionSeleccionada.Codigo}", "Compra Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ActualizarGrillaInversiones(Inversor inversor)
        {
            grillaInversiones.Rows.Clear();
            inversor.Inversiones.ForEach(inversion =>
            {
                var accion = inversion.Accion;
                grillaInversiones.Rows.Add(
                    accion.Codigo,
                    accion.Denominacion,
                    accion.CotizacionActual,
                    accion.CantidadEmitida,
                    inversion.Cantidad,
                    inversion.CalcularValorTotalDeLaInversion()
                );
            });
        }

        private static void AsignarInversionAInversor(in Inversor inversor, in Accion accion)
        {
            var codigoAccion = accion.Codigo;
            if (EsInversionExistente(inversor, codigoAccion))
            {
                ObtenerInversionPorCodigoDeAccion(inversor, codigoAccion).Cantidad++;
            }
            else
            {
                AgregarNuevaInversion(inversor, accion);
            }
        }

        private static void AgregarNuevaInversion(Inversor inversor, Accion accion)
        {
            inversor.Inversiones.Add(new Inversion(accion));
        }

        private static Inversion ObtenerInversionPorCodigoDeAccion(Inversor inversorSeleccionado, string codigoAccion) => inversorSeleccionado.Inversiones.First(inversion => inversion.Accion.Codigo == codigoAccion);

        private static bool EsInversionExistente(Inversor inversorSeleccionado, string codigoAccion) => inversorSeleccionado.Inversiones.Any(inversion => inversion.Accion.Codigo == codigoAccion);

        private static void ReducirCantidadEmitida(in Accion accionSeleccionada) => accionSeleccionada.CantidadEmitida--;
    }
}
