using System.Text.RegularExpressions;

namespace uai_poo_actividad_integradora_2.Utilidades.Acciones
{
    public static partial class UtilidadesAccion
    {
        [GeneratedRegex(@"([A-Z]{4})+-([0-9]{4})+-([A-Z]{1})([0-9]{1})([A-Z]{1})([0-9]{1})")]
        private static partial Regex CodigoAccionRegex();

        public static bool ValidarCodigoAccion(this string codigoAccion)
            => CodigoAccionRegex().IsMatch(codigoAccion);
    }
}
