<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formSecao.aspx.cs" Inherits="cinema2018.Secao1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Secao</title>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="secao" runat="server">
    <div id="div">
    <h3> Cadastro de seção </h3> <br/> <br/>
    <asp:Label id="lblSala" Text="Sala" runat="server" CssClass="label" /> <br/>
    <asp:TextBox id="txtSala"  runat="server" CssClass="textbox" /> <br/>  <br/>
    <asp:Label id="lblHorario" Text="Horario" runat="server" CssClass="label" /> <br/>
    <asp:TextBox id="txtHorario"  runat="server" CssClass="textbox" /> <br/>  <br/>
     <asp:Label id="lblCadeiras" Text="Quantidade de cadeiras" runat="server" CssClass="label" /> <br/>
    <asp:TextBox id="txtCadeiras"  runat="server" CssClass="textbox" /> <br/>  <br/>
     <asp:Label id="lblValor" Text="Valor" runat="server" CssClass="label" /> <br/>
    <asp:TextBox id="txtValor"  runat="server" CssClass="textbox" /> <br/>  <br/>
     <asp:Label id="lblFilme" Text="Filme" runat="server" CssClass="label" /> <br/>
    <asp:DropDownList id="ddlFilme"  runat="server" 
            onselectedindexchanged="ddlFornecedor_SelectedIndexChanged" /> <br/>  <br/>
    <asp:Button id="btnNovo" Text="Novo" runat="server" CssClass="button" 
            onclick="btnNovo_Click"  />  
    <asp:Button id="btnEnviar" Text="Enviar" runat="server" CssClass="button" 
            onclick="btnEnviar_Click"  /> 
     <asp:Button id="btnAtualizar" Text="Atualizar" runat="server" CssClass="button" 
            onclick="btnAtualizar_Click"  /> 
    <asp:Button id="btnExcluir" Text="Excluir" runat="server" CssClass="button" 
            onclick="btnExcluir_Click"  /> <br/>  <br/> <br/>
    <asp:GridView id="gvSecao" runat="server" 
            onselectedindexchanged="gvSecao_SelectedIndexChanged"    />

    </div>
    </form>
</body>
</html>
