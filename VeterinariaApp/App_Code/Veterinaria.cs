using System.Data;
using mis_conexiones;

namespace VeterinariaApp
{
    

    public class VeterinariaPadre
    {
        Conexiones conn = new Conexiones();
        private int _cantidad_veterinaios;
        private string _fecha_inauguracion;
        private int _num_salas;

        //metodos
        

        public string registrarMascota(Mascota mascota)
        {
            return conn.insertarMascota(mascota);
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

    public class Mascota
    {
        private string _nombre;
        private string _propietario;
        private int _edad;

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Propietario
        {
            get
            {
                return _propietario;
            }

            set
            {
                _propietario = value;
            }
        }

        public int Edad
        {
            get
            {
                return _edad;
            }

            set
            {
                _edad = value;
            }
        }
    }
}