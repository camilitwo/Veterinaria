using System;
using System.Collections.Generic;
using System.Data;
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
            string usuario = Request.QueryString["usuario"];
            btn_registrarMascota.Visible = false;
            if ("veterinario".Equals(usuario))
            {
                btn_registrarMascota.Visible = true;
            }
        }

        protected void btn_verMascota_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerMascota.aspx?usuario=" + Request.QueryString["usuario"]);
        }

        protected void btn_registrarMascota_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarMascota.aspx");
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            string seleccion = Menu1.SelectedItem.Text;

            VeterinariaHijo vet = new VeterinariaHijo();
            DataTable dt;
            if ("Ver lista de propietarios".Equals(seleccion))
            {
                dt = vet.verListaPropietarios();
            }else
            {
                dt = vet.verListaMascotas();
            }
            gv_sitio.Columns.Clear();
            gv_sitio.DataSource = dt;
            gv_sitio.DataBind();
            foreach (DataColumn column in dt.Columns)
            {
                BoundField field = new BoundField();
                field.DataField = column.ColumnName;
                field.HeaderText = column.ColumnName;
                gv_sitio.Columns.Add(field);
            }
        }
    }
}