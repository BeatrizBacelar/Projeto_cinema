using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cinema2018
{
    public partial class Secao1 : System.Web.UI.Page
    {
        SecaoBD secaoBD = new SecaoBD();
        FilmeBD filmeBD = new FilmeBD();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void PreencheDDL()
        {
            ddlFilme.DataSource = filmeBD.ListarFilme(); // jogou tudo que tinha no DataSet para o ddl

            ddlFilme.DataTextField = "nomeFilme"; // o que aparece no dropdown
            ddlFilme.DataValueField = "codigoFilme"; // campo chave da tabela

            ddlFilme.DataBind(); // permite visualizar tudo que esta dentro da ddl

        }

        public void PreencheGrid()
        {
            gvSecao.DataSource = secaoBD.ListarSecao();  // jogou tudo que tinha no DataSet para o grid
            gvSecao.DataBind(); // permite visualizar tudo que esta dentro do grid


        }
        public void limpar()
        {
            // limpar o campo titulo
            txtSala.Text = "";
            txtSala.Focus();
            // limpar o campo noticia
            txtHorario.Text = "";
            txtHorario.Focus();

        }
        protected void btnNovo_Click(object sender, EventArgs e)
        {

            limpar();
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(ddlFilme.SelectedValue);
            double valor = Convert.ToDouble(txtValor.Text);
            int sala = Convert.ToInt32(txtSala.Text);
            int cadeiras = Convert.ToInt32(txtCadeiras.Text);

            Secao secao = new Secao (sala,txtHorario.Text, cadeiras,valor,x); // pega o nome da tela e joga dentro do objeto
            int retorno = secaoBD.IncluirSecao(secao) ; // inclui a categoria que pegou do campo através do objeto // a variavel retorno serve para testar se deu certo a inclusao

            PreencheGrid(); //atualiza o grid para ver a inclusao do obj

            Response.Redirect("index.aspx");
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {

            // para alterar o campo
            int codigoSecao = Convert.ToInt32(gvSecao.SelectedValue);
            int x = Convert.ToInt32(ddlFilme.SelectedValue);
            double valor = Convert.ToDouble(txtValor.Text);
            int sala = Convert.ToInt32(txtSala.Text);
            int cadeiras = Convert.ToInt32(txtCadeiras.Text);

            Secao secao = new Secao(sala, txtHorario.Text, cadeiras, valor, x);
            secaoBD.AlterarSecao(secao, codigoSecao);
            PreencheGrid(); //atualiza o grid para ver a inclusao do obj

        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            int codigoSecao = Convert.ToInt32(gvSecao.SelectedValue);
            secaoBD.ExcluirSecao(codigoSecao);

            PreencheGrid();
        }

        protected void ddlFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}