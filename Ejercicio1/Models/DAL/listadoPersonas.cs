using Ejercicio1.Models.Entidades;

namespace Ejercicio1.Models.DAL
{
    public static class listadoPersonas
    {
        /// <summary>
        /// Función que devuelve un listado de personas.
        /// Precondición: Ninguna
        /// PostCondición: Ninguna
        /// </summary>
        /// <returns>lista</returns>
        public static List<clsPersona> listaPersonas()
        {
            List<clsPersona> lista = new List<clsPersona>(){
                new clsPersona(1, "Alejandro", "Sosa", 1),
                new clsPersona(2, "Angel", "Navarro", 2),
                new clsPersona(3, "Antonio", "Navarro", 3)
            };
            return lista;
        }
    }
}
