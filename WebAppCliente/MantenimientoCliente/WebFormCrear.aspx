
<%@ Page Title="Acerca de" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormCrear.aspx.cs" Inherits="WebAppCliente.WebFormCrear" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <div>
      <table>
            

               <tr> <td> Nombre </td> <td> <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox> </td> </tr>  

          <tr> <td> Phone </td> <td> <asp:TextBox ID="TextBoxPhone" runat="server"></asp:TextBox> </td> </tr>  

                   <tr> <td> <asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click"  /> </td>  </tr>
                  
              </table>
    </div>
    </asp:Content>
