using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace VeterinariaApp
{
    public partial class AgregarMascota : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = "Prueba";
            mascota.Propietario = "Camilo";
            mascota.Edad = 2;

            VeterinariaHijo vet = new VeterinariaHijo();
            vet.registrarMascota(mascota);
        }
    }
}