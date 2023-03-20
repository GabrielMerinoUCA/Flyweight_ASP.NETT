using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Flyweight_Pattern.Buisness;

namespace Flyweight_Pattern
{
    public partial class NuevoLibro : System.Web.UI.Page
    {
        private Store s;
        protected void Page_Load(object sender, EventArgs e)
        {
            s = new Store();
            s.LoadFromDataBase();
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string titulo = tbTitulo.Text;
            float precio = float.Parse(tbPrecio.Text);
            string tipo = tbCategoria.Text;
            string autor = tbAutor.Text;
            string extras = tbExtras.Text;

            s.saveToDataBase(titulo, precio, tipo, autor, extras);
            Response.Redirect("~\\Default.aspx");
        }
    }
}