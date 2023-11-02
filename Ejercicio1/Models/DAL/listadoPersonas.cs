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
                new clsPersona("Alejandro", "Sosa", 1),
                new clsPersona("Angel", "Navarro", 2),
                new clsPersona("Antonio", "Navarro", 3)
            };
            return lista;
        }
    }
}
