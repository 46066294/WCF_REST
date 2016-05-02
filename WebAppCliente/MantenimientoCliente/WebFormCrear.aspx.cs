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
    public partial class WebFormCrear : System.Web.UI.Page
    {
        public IOperacion MyService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        private void Limpiar()
        {
            TextBoxNombre.Text = String.Empty;
            TextBoxPhone.Text = String.Empty;
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.Nombre = TextBoxNombre.Text;
            cliente.Phone = TextBoxPhone.Text;

            this.MyService.Add(cliente);
            Limpiar();
            Response.Redirect("PaginaWeb1.aspx");
         
        }
    }
}