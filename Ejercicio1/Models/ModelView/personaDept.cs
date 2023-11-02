using Ejercicio1.Models.Entidades;

namespace Ejercicio1.Models.ModelView
{
    public class personaDept : clsPersona
    {
        String nombreDept;
        public personaDept() : base() 
        {
            this.nombreDept = "Informatica";
        }
        public personaDept(string nombre, string apellido, int id, String nombreDept)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.IdDept = id;
            this.nombreDept = nombreDept;
        }

    }
}
