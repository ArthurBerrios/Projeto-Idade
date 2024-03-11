using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjAniversario
{
    public partial class Aniversario : System.Web.UI.Page
    {
        static List<string> nome = new List<string>();
        static List<string> datanascimento = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendario1_SelectionChanged(object sender, EventArgs e)
        {
            var date = Calendario1.SelectedDate;
            var dia = date.Day;
            var ano = date.Year;
            var mes = date.ToString("MMMM");
            txtData1.Text = dia + "/" + mes + "/" + ano;
        }

        protected void Calendario2_SelectionChanged(object sender, EventArgs e)
        {
            var date = Calendario2.SelectedDate;
            var dia = date.Day;
            var ano = date.Year;
            var mes = date.ToString("MMMM");
            txtData2.Text = dia + "/" + mes + "/" + ano;
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            String n = txtData1.Text.ToString();
            String f = txtData2.Text.ToString();
            String Nomee = txtNome.Text.ToString();
            nome.Add(Nomee);
            datanascimento.Add(f);
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            DateTime datafinal = Convert.ToDateTime(txtData2.Text);
            DateTime datainicial = Convert.ToDateTime(txtData1.Text);
            int dias = datafinal.Subtract(datainicial).Days / 365;

            String n = txtData1.Text.ToString();
            String f = txtData2.Text.ToString();
            String x = "";
            for (int i = 0; i < nome.Count && i< datanascimento.Count; i++ )
            {
                x = x + " Em " + datanascimento.ElementAt(i) + " Você vai fazer " + dias.ToString() + " anos, " + nome.ElementAt(i);
            }
            lblResposta.Text = x;
        }
    }
}