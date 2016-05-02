
<%@ Page Title="Acerca de" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ActualizarCliente.aspx.cs" Inherits="WebAppCliente.ActualizarCliente" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">


    <div>
    

         <table>
              <tr> <td> Id </td> <td> <asp:TextBox ID="TextBoxId" runat="server" Enabled="False"></asp:TextBox> </td> </tr> 

               <tr> <td> Nombre </td> <td> <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox> </td> </tr>  

          <tr> <td> Phone </td> <td> <asp:TextBox ID="TextBoxPhone" runat="server"></asp:TextBox> </td> </tr>  

                   <tr> <td> <asp:Button ID="Button1" runat="server" Text="Actualizar" OnClick="Button1_Click" /> </td>  </tr>
                  
              </table>


    </div>
   

    </asp:Content>
