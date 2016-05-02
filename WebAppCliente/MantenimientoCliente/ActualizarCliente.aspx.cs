using Dominio;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCliente
{
    public partial class ActualizarCliente : System.Web.UI.Page
    {
        public IOperacion MyService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBoxId.Text = Request.QueryString["Id"];
                TextBoxNombre.Text = Request.QueryString["Nombre"];
                TextBoxPhone.Text = Request.QueryString["Phone"];
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = MyService.Get(int.Parse(TextBoxId.Text));

            cliente.Nombre = TextBoxNombre.Text;
            cliente.Phone = TextBoxPhone.Text;

            MyService.Update(cliente);

            Response.Redirect("PaginaWeb1.aspx");
        }
    }
}