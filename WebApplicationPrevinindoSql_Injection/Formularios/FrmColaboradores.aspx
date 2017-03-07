<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmColaboradores.aspx.cs" Inherits="WebApplicationPrevinindoSql_Injection.Formularios.Colaboradores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 492px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <asp:Button ID="BtnConsultar" runat="server" Height="22px" OnClick="BtnConsultar_Click" Text="Consultar" Width="69px" />
        <asp:TextBox ID="txtConsultar" runat="server"></asp:TextBox>
        <asp:GridView ID="GdVResultado" runat="server">
        </asp:GridView>
    
    </form>
</body>
</html>
