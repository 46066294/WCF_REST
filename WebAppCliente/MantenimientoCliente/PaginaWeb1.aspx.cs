using Dominio;
using Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCliente
{
    public partial class PaginaWeb1 : System.Web.UI.Page
    {
        public IOperacion MyService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = this.MyService.Get(1).Nombre.ToString();
            if (!IsPostBack)
            {
                ListarGridView();
            }
        }

        private void ListarGridView() {
            GridView1.DataSource = this.MyService.GetAll().ToList();
            GridView1.DataBind(); 
        }
        
        //private void Limpiar()
        //{
        //    TextBoxNombre.Text = String.Empty;
        //    TextBoxPhone.Text = String.Empty;
        //}


        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    var cliente = new Cliente();
        //    cliente.Nombre = TextBoxNombre.Text;
        //    cliente.Phone = TextBoxPhone.Text;

        //    this.MyService.Add(cliente);

        //    ListarGridView();
        //    Limpiar();
        //}

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
       

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            var index = e.RowIndex;
           int valor = int.Parse( GridView1.Rows[index].Cells[1].Text);
           Cliente cliente = this.MyService.Get(valor);

            MyService.Delete(cliente);

            Response.Redirect("PaginaWeb1.aspx");

           //ListarGridView();

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            /*

            lblId.Text = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            lblNombre.Text = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text; 
          // string telefono =  GridView1.Rows[GridView1.EditIndex].Cells[3].Text;
         



          //TextBox TextBoxNombre = (TextBox)GridView1.Rows[e.RowIndex].FindControl("Nombre");

            //TextBox TextBoxNombre = (TextBox)GridView1.Rows[e.RowIndex].FindControl("Nombre");
            //TextBox TextBoxPhone = (TextBox)GridView1.Rows[e.RowIndex].FindControl("Phone");

           // TextBox TextBoxNombre = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;

          int id = int.Parse(lblId.Text);
          string Nombre = lblNombre.Text;//((TextBox) GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).ToString();
           string Phone = lblPhone.Text; 


           //string Nombre = GridView1.Rows[e.RowIndex].Cells[2].Controls[0].Text;
            //string Phone = GridView1.Rows[e.RowIndex].Cells[3].Controls[0].Text;

            Cliente cliente = MyService.Get(id);

            cliente.Nombre = Nombre;
            cliente.Phone = Phone;
            
            MyService.Update(cliente);

            Response.Redirect("PaginaWeb1.aspx");
            
       */



        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
         /*   GridView1.EditIndex = e.NewEditIndex;

          

            ListarGridView();*/

            
            string id = GridView1.Rows[e.NewEditIndex].Cells[1].Text.Trim();
            string nombre = GridView1.Rows[e.NewEditIndex].Cells[2].Text.Trim();
            string phone = GridView1.Rows[e.NewEditIndex].Cells[3].Text.Trim();




            Response.Redirect("~/MantenimientoCliente/ActualizarCliente.aspx?Id=" + id + " &Nombre=" + nombre + "&Phone=" + phone); 

          
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;

            ListarGridView();
        }
    }
}