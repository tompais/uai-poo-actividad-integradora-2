using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uai_poo_actividad_integradora_2.Clases.Acciones
{
    public class Accion(string codigo, string denominacion, string cotizacionActual, string cantidadEmitida) : IDisposable
    {
        public required string Codigo { get; set; } = codigo;
        public required string Denominacion { get; set; } = denominacion;
        public required string CotizacionActual { get; set; } = cotizacionActual;
        public required string CantidadEmitida { get; set; } = cantidadEmitida;

        ~Accion()
        {
            Dispose();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
