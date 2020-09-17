<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="cinema2018.Principal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cinemaker</title>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
   
    <form id="principal" runat="server">
    <div>
    <div id="div">   <%-- criar uma div menu dentro da div geral para adcionar a opção de ir para o form categoria ou noticia --%>
     <h1> Cinemaker </h1> <br/> <br />
     <h3> Olá! Nós somos a Cinemaker, uma empresa inovadora na área de cinema em todos Brasil, temos salas exclusivas que lhe oferecem o melhor conforto durante o seu lazer. </h3> <br/> <br />
    <asp:Label id="lblCadastro" Text="Para realizar cadastros" runat="server" /> <br/>
      <a id="A1"  href="formSecao.aspx" runat="server" >Seção</a> <br/>
    <a id="A2"  href="formFilme.aspx" runat="server" >Filme</a> <br/>
    <a id="A3"   href="formFornecedor.aspx" runat="server" >Fornecedor</a> <br/> <br/> <br/> <br/>

     <h3> Logo abaixo você pode escolher o filme que deseja assistir. </h3> <br/> 
      
      <asp:GridView ID="gvFilme" runat="server" CellPadding="4" 
            GridLines="None" onselectedindexchanged="gvNoticias_SelectedIndexChanged" 
            ForeColor="#333333">
          <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
          <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </div>



    </div>
    </form>
</body>
</html>
