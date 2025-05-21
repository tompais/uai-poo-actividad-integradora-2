using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uai_poo_actividad_integradora_2.Clases.Inversores
{
    public class Inversor(string legajo, string nombre, string apellido, string dni) : IDisposable
    {
        public required string Legajo { get; set; } = legajo;
        public required string Nombre { get; set; } = nombre;
        public required string Apellido { get; set; } = apellido;
        public required string DNI { get; set; } = dni;

        ~Inversor()
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
