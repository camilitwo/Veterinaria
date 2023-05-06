using System.Data;
using mis_conexiones;

namespace VeterinariaApp
{
    public class VeterinariaPadre
    {
        private int _cantidad_veterinaios;
        private string _fecha_inauguracion;
        private int _num_salas;

        //metodos
        

        public void registrarMascota()
        {

        }
        public void registrarPropietario()
        {

        }
    }

    public class VeterinariaHijo: VeterinariaPadre
    {
        Conexiones conn = new Conexiones();
        public DataTable verListaMascotas()
        {
            
            return conn.LeeBBDDAccess("mascota");
        }

        public DataTable verListaPropietarios()
        {
            return conn.LeeBBDDAccess("propietario"); ;
        }
    }
}