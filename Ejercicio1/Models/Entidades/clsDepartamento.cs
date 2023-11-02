namespace Ejercicio1.Models.Entidades
{
    public class clsDepartamento
    {
        int id;
        String nombre;

        public clsDepartamento()
        {
            id = 1;
            nombre = "Informática";
        }
        public clsDepartamento(int id, String nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }
    }
}
