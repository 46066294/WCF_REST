﻿
<%@ Page Title="Acerca de" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaginaWeb1.aspx.cs" Inherits="WebAppCliente.PaginaWeb1" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <div>
      
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/MantenimientoCliente/WebFormCrear.aspx">Crear Cliente</asp:HyperLink>
        <asp:GridView ID="GridView1" runat="server" 
            AutoGenerateDeleteButton="True"
             AutoGenerateEditButton="True" 
            OnRowDeleted="GridView1_RowDeleted"
             OnRowDeleting="GridView1_RowDeleting" 
            OnRowUpdating="GridView1_RowUpdating" 
            OnSelectedIndexChanged="GridView1_SelectedIndexChanged" 
            OnRowCancelingEdit="GridView1_RowCancelingEdit" 
            OnRowEditing="GridView1_RowEditing">

        </asp:GridView>
    </div>

          <div>
      
         <%--     <table>
               <tr> <td> Nombre </td> <td> <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox> </td> </tr>  

          <tr> <td> Phone </td> <td> <asp:TextBox ID="TextBoxPhone" runat="server"></asp:TextBox> </td> </tr>  

                   <tr> <td> <asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" /> </td>  </tr>  

                  
              </table>--%>

      
    </div>
        <asp:Label ID="lblId" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblPhone" runat="server" Text=""></asp:Label>
       

    </asp:Content>