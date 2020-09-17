using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace cinema2018
{
    public partial class Filme1 : System.Web.UI.Page
    {

        DataSet ds = new DataSet();
        FilmeBD filmeBD = new FilmeBD(); // obj da classe categoriaBD
        FornecedorBD fornecedorBD = new FornecedorBD();
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        public void PreencheDDL()
        {
            ddlFornecedor.DataSource = fornecedorBD.ListarFornecedor();// jogou tudo que tinha no DataSet para o ddl

            ddlFornecedor.DataTextField = "nomeFornecedor"; // o que aparece no dropdown
            ddlFornecedor.DataValueField = "codigoFornecedor"; // campo chave da tabela

            ddlFornecedor.DataBind(); // permite visualizar tudo que esta dentro da ddl

        }

        public void PreencheGrid()
        {
            gvFilme.DataSource = filmeBD.ListarFilme();  // jogou tudo que tinha no DataSet para o grid
            gvFilme.DataBind(); // permite visualizar tudo que esta dentro do grid


        }

        public void limpar()
        {
            // limpar o campo titulo
            txtFilme.Text = "";
            txtFilme.Focus();
            // limpar o campo noticia
            txtDuracao.Text = "";
            txtDuracao.Focus();

        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(ddlFornecedor.SelectedValue);
            Filme filme = new Filme(txtFilme.Text, txtDuracao.Text, x); // pega o nome da tela e joga dentro do objeto
            int retorno = filmeBD.IncluirFilme(filme); // inclui a categoria que pegou do campo através do objeto // a variavel retorno serve para testar se deu certo a inclusao

            PreencheGrid(); //atualiza o grid para ver a inclusao do obj

            Response.Redirect("index.aspx");
        }

        protected void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            int codigoFilme = Convert.ToInt32(gvFilme.SelectedValue);
            filmeBD.ExcluirFilme(codigoFilme);

            PreencheGrid();
        }

        protected void gvFilme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            // para alterar o campo
            int codigoFilme = Convert.ToInt32(gvFilme.SelectedValue);
            int x = Convert.ToInt32(ddlFornecedor.SelectedValue);
            Filme filme = new Filme(txtFilme.Text, txtDuracao.Text, x);
            filmeBD.AlterarFilme(filme, codigoFilme);
            PreencheGrid(); //atualiza o grid para ver a inclusao do obj

        }

        protected void ddlFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}