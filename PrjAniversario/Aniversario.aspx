<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Aniversario.aspx.cs" Inherits="PrjAniversario.Aniversario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="Calendario1" runat="server" OnSelectionChanged="Calendario1_SelectionChanged"></asp:Calendar><br />
            <asp:TextBox ID="txtData1" runat="server"></asp:TextBox><br />
             <asp:Calendar ID="Calendario2" runat="server" OnSelectionChanged="Calendario2_SelectionChanged"></asp:Calendar><br />
            <asp:TextBox ID="txtData2" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label><br />
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" /><br />
            <asp:Button ID="btnMostrar" runat="server" Text="Mostrar" OnClick="btnMostrar_Click" /><br />
            
        <asp:Label ID="lblResposta" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
