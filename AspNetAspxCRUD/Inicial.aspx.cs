using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetAspxCRUD
{
    public partial class Inicial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = txbNome.Text;
            p.idade = int.Parse(txbIdade.Text);
            p.altura = int.Parse(txbAltura.Text);

            if (p.gravarPessoa())
            {
                lblGravou.Text = "Gravado com sucesso!";
            }
            else
            {
                lblGravou.Text = "Erro ao gravar!";
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Banco bd = new Banco();

            dt = bd.executeQuery("select * from pessoas");
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.id = int.Parse(txbIdExcluir.Text);

            if (p.excluirPessoa())
            {
                lblGravou.Text = "Excluido com sucesso!";
            }
            else
            {
                lblGravou.Text = "Erro ao excluir!";
            }
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
              Pessoa p = new Pessoa();
            p.id = int.Parse(txbIdAlt.Text);
            p.nome = txbNomeAlt.Text;
            p.idade = int.Parse(txbIdadeAlt.Text);
            p.altura = int.Parse(txbAlturaAlt.Text);

            if (p.alterarPessoa())
            {
                lblAlterou.Text = "Alterado com sucesso!";
            }
            else
            {
                lblAlterou.Text = "Erro ao alterar!";
            }
        }
    }
}