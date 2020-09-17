using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cinema2018
{
    public partial class Principal : System.Web.UI.Page
    {
        FilmeBD filmeBD = new FilmeBD();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void PreencheGrid()
        {
            gvFilme.DataSource = filmeBD.ListarFilme();  // jogou tudo que tinha no DataSet para o grid
            gvFilme.DataBind(); // permite visualizar tudo que esta dentro do grid


        }

        protected void gvNoticias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // quando clicar na linha pegar o codigo e aparacer

            string cod = gvFilme.SelectedRow.Cells[1].Text; // pegar o codigo
            Session["cod"] = cod; // criar uma seção com o codigo para levar p/ onde quiser
       //   Response.Redirect("formNoticiaSelecionada.aspx"); para abrir outro formulario

        }
    }
}