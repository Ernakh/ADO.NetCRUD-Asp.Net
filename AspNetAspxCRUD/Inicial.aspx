<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicial.aspx.cs" Inherits="AspNetAspxCRUD.Inicial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset>
                <legend>Cadastrar:</legend>

                <asp:TextBox ID="txbNome" runat="server"></asp:TextBox>
                <br />
                <asp:TextBox ID="txbIdade" runat="server"></asp:TextBox>
                <br />
                <asp:TextBox ID="txbAltura" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnGravar" runat="server" Text="Gravar" OnClick="btnGravar_Click" />
                <br />
                <asp:Label ID="lblGravou" runat="server" Text=""></asp:Label>
            </fieldset>
        </div>


        <div>
            <fieldset>
                <legend>Consultar:</legend>
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
                <asp:Button ID="btnDataReader" runat="server" Text="Consultar DataReader" OnClick="btnDataReader_Click" />
                <asp:Label ID="lblDataReader" runat="server" Text=""></asp:Label>
            </fieldset>
        </div>

        <div>
            <fieldset>
                <legend>Excluir:</legend>
                <asp:TextBox ID="txbIdExcluir" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="btnExcluir" runat="server" Text="Button" OnClick="btnExcluir_Click" />
                <asp:Label ID="lblExcluiu" runat="server" Text=""></asp:Label>
                <br />
            </fieldset>
        </div>

        <div>
            <fieldset>
                <legend>Alterar:</legend>

                <asp:TextBox ID="txbIdAlt" runat="server"></asp:TextBox>
                <br />
                <asp:TextBox ID="txbNomeAlt" runat="server"></asp:TextBox>
                <br />
                <asp:TextBox ID="txbIdadeAlt" runat="server"></asp:TextBox>
                <br />
                <asp:TextBox ID="txbAlturaAlt" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click" />
                <br />
                <asp:Label ID="lblAlterou" runat="server" Text=""></asp:Label>
            </fieldset>
        </div>

    </form>
</body>
</html>
