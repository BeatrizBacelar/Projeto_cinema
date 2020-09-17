<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formFornecedor.aspx.cs" Inherits="cinema2018.Fornecedor1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fornecedor</title>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="fornecedor" runat="server">
    <div id="div">
    <h3> Cadastro de fornecedor </h3>  <br/> <br/>
     <asp:Label id="lblcnpj" Text="CNPJ" runat="server" CssClass="label" /> <br/>
    <asp:TextBox id="txtCnpj"  runat="server" CssClass="textbox" /> <br/>  <br/>
    <asp:Label id="lblNome" Text="Nome da empresa" runat="server" CssClass="label" /> <br/>
    <asp:TextBox id="txtNome"  runat="server" CssClass="textbox" /> <br/>  <br/>
     <asp:Label id="lblEndereco" Text="Endereco" runat="server" CssClass="label" /> <br/>
    <asp:TextBox id="txtEndereco"  runat="server" CssClass="textbox" /> <br/>  <br/>
    <asp:Button id="btnNovo" Text="Novo" runat="server" CssClass="button" 
            onclick="btnNovo_Click"  />  
    <asp:button id="btnEnviar" Text="Enviar" runat="server" CssClass="button" 
            onclick="btnEnviar_Click"  /> 
     <asp:Button id="btnAtualizar" Text="Atualizar" runat="server" CssClass="button" 
            onclick="btnAtualizar_Click"  /> 
    <asp:Button id="btnExcluir" Text="Excluir" runat="server" CssClass="button" 
            onclick="btnExcluir_Click"  />  <br/>  <br/>  <br/>
    <asp:GridView id="gvFornecedor" runat="server" 
            onselectedindexchanged="gvFornecedor_SelectedIndexChanged"    />
    </div>
    </form>
</body>
</html>
