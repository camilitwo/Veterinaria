using System;
using mis_conexiones;
using System.Data;
using System.Web.UI.WebControls;

namespace VeterinariaApp
{
    public partial class VerMascota : System.Web.UI.Page
    {
        Conexiones conn = new Conexiones();
        protected void Page_Load(object sender, EventArgs e)
        {
            Gv_mascotas.Visible = false;
            string usuario = Request.QueryString["usuario"];
            Btn_registrar_nueva_mascota.Visible = false;
            if ("veterinario".Equals(usuario))
            {
                Btn_registrar_nueva_mascota.Visible = true;
            }
        }

        protected void Btn_mostar_mascotas_Click(object sender, EventArgs e)
        {
            

            DataTable dt = this.conn.LeeBBDDAccess("mascota");
            Gv_mascotas.Columns.Clear();
            Gv_mascotas.DataSource = dt;
            Gv_mascotas.DataBind();
            foreach (DataColumn column in dt.Columns)
            {
                BoundField field = new BoundField();
                field.DataField = column.ColumnName;
                field.HeaderText = column.ColumnName;
                Gv_mascotas.Columns.Add(field);
            }

            Gv_mascotas.Visible = true;
        }

        protected void Btn_registrar_nueva_mascota_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarMascota.aspx");
        }
    }
}