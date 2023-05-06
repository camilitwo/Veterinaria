using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VeterinariaApp
{
    public partial class SitioVeterinario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btn_verMascota_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerMascota.aspx?usuario=" + Request.QueryString["usuario"]);
        }
    }
}