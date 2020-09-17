<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formFilme.aspx.cs" Inherits="cinema2018.Filme1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Filme</title>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="filme" runat="server">
    <div id="div" style="height: 483px; width: 324px">
     <h3> Cadastro de filme </h3> <br/> <br/>
    <asp:Label id="lblSala" Text="Nome" runat="server" CssClass="label" /> <br/>
    <asp:TextBox id="txtFilme"  runat="server" CssClass="textbox" /> <br/>  <br/>
    <asp:Label id="lblDuracao" Text="Horario" runat="server" CssClass="label" /> <br/>
    <asp:TextBox id="txtDuracao"  runat="server" CssClass="textbox" /> <br/>  <br/>
    <asp:Label id="lblFornecedor" Text="Código do Fornecedor" runat="server" 
            CssClass="label" /> <br/>
   <asp:DropDownList id="ddlFornecedor"  runat="server" 
            onselectedindexchanged="ddlFornecedor_SelectedIndexChanged" /> <br/>  <br/>
    <asp:Button id="btnNovo" Text="Novo" runat="server" CssClass="button" 
            onclick="btnNovo_Click"  />  
    <asp:Button id="btnEnviar" Text="Enviar" runat="server" CssClass="button" 
            onclick="btnEnviar_Click"  />
    <asp:Button id="btnAtualizar" Text="Atualizar" runat="server" CssClass="button" 
            onclick="btnAtualizar_Click"  /> 
    <asp:Button id="btnExcluir" Text="Excluir" runat="server" CssClass="button" 
            onclick="btnExcluir_Click"  /> <br/>  <br/>  <br/>
    <asp:GridView id="gvFilme" runat="server" 
            onselectedindexchanged="gvFilme_SelectedIndexChanged"    />
    </div>
    </form>
</body>
</html>
