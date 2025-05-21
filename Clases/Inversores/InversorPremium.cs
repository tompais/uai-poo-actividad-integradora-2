using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uai_poo_actividad_integradora_2.Clases.Inversores
{
    public class InversorPremium(string legajo, string nombre, string apellido, string dni) : Inversor(legajo, nombre, apellido, dni)
    {
        ~InversorPremium()
        {
            Dispose();
        }
    }
}
