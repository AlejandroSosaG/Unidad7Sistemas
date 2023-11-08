using Ejercicio1.Models.Entidades;

namespace Ejercicio1.Models.DAL
{
    public class listadoDept
    {
        /// <summary>
        /// Función que devuelve un listado de departamentos.
        /// Precondición: Ninguna
        /// PostCondición: Ninguna
        /// </summary>
        /// <returns>lista</returns>
        public static List<clsDepartamento> listaDept()
        {
            List<clsDepartamento> lista = new List<clsDepartamento>(){
                new clsDepartamento(1, "Finanzas"),
                new clsDepartamento(2, "Recursos humanos"),
                new clsDepartamento(3, "Producción")
            };
            return lista;
        }
    }
}
