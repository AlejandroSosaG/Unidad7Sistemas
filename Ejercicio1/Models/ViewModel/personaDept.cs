using Ejercicio1.Models.DAL;
using Ejercicio1.Models.Entidades;

namespace Ejercicio1.Models.ViewModel
{
    public class personaDept : clsPersona
    {
        private List<clsDepartamento> departamentos;
        public personaDept() : base() 
        {
            this.departamentos = listadoDept.listaDept();
        }
        

        public List<clsDepartamento> Departamentos { 
            get { return departamentos; } 
        }
    }
}
