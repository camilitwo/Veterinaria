using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using mis_conexiones;
using System.Data;

namespace VeterinariaApp
{
    public partial class Index : System.Web.UI.Page
    {
        Conexiones conn = new Conexiones();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_ingreso_Click(object sender, EventArgs e)
        {
            DataTable dt = this.conn.obtenerUsuarioLogeado(Txt_usuario.Text);

            if (Txt_password.Text.Equals(dt.Rows[0].Field<string>("clave")))
            {
                Response.Redirect("SitioVeterinario.aspx?usuario="+ Txt_usuario.Text);
            }else
            {
                Lbl_mensaje.Text = "LA contraseña no coincide, ingresa bien burro";
            }

        }
    }
}