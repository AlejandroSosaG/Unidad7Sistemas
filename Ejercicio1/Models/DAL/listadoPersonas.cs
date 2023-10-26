using Ejercicio1.Models.Entidades;

namespace Ejercicio1.Models.DAL
{
    public class listadoPersonas : clsPersona
    {
        List<clsPersona> lista;
        public listadoPersonas()
        {
            lista = new List<clsPersona>();
        }
    }
}
