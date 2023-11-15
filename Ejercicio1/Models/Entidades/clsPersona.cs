using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models.Entidades
{
    public class clsPersona
    {
        #region atributos
        private int _id;
        private string nombre;
        private string apellido;
        private int idDept;
        #endregion

        #region constructores
        public clsPersona() {
            this._id = 0;
            this.nombre = "";
            this.apellido = "";
            this.idDept = 1;
        }

        public clsPersona (int id, string nombre, string apellido, int idDept) {
            this._id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.idDept = idDept;
        }
        #endregion

        #region propiedades
        public int Id
        {
            get { return Id; }
        }
        public String Nombre {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Apellido {
            get { return apellido; }
            set { apellido = value; }
        }
        public int IdDept
        {
            get { return idDept; }
            set { idDept = value; }
        }
        public String Direccion { get; set; }

        public String NombreCompleto {
            get { return $"{nombre} {apellido}"; }
        }

        #endregion

    }
}
