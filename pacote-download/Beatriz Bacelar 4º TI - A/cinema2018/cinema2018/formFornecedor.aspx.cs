using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cinema2018
{
    public partial class Fornecedor1 : System.Web.UI.Page
    {
        FornecedorBD fornecedorBD = new FornecedorBD();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void limpar()
        {
            // limpar o campo titulo
            txtCnpj.Text = "";
            txtCnpj.Focus();
            txtNome.Text = "";
            txtNome.Focus();
            // limpar o campo noticia
            txtEndereco.Text = "";
            txtEndereco.Focus();

        }


        public void PreencheGrid()
        {
            gvFornecedor.DataSource = fornecedorBD.ListarFornecedor(); // jogou tudo que tinha no DataSet para o grid
            gvFornecedor.DataBind(); // permite visualizar tudo que esta dentro do grid


        }
        protected void gvNoticia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
           
            Fornecedor fornecedor = new Fornecedor (txtCnpj.Text, txtNome.Text, txtEndereco.Text); // pega o nome da tela e joga dentro do objeto
            int retorno = fornecedorBD.IncluirFornecedor(fornecedor); // inclui a categoria que pegou do campo através do objeto // a variavel retorno serve para testar se deu certo a inclusao

            PreencheGrid(); //atualiza o grid para ver a inclusao do obj

            Response.Redirect("index.aspx");
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            // para alterar o campo
            int codigoFornecedor = Convert.ToInt32(gvFornecedor.SelectedValue);
            Fornecedor fornecedor = new Fornecedor(txtCnpj.Text, txtNome.Text, txtEndereco.Text);
            fornecedorBD.AlterarFornecedor(fornecedor, codigoFornecedor);
            PreencheGrid(); //atualiza o grid para ver a inclusao do obj

        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            int codigoFornecedor = Convert.ToInt32(gvFornecedor.SelectedValue);
            fornecedorBD.ExcluirFornecedor(codigoFornecedor);

            PreencheGrid();
        }

        protected void gvFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}