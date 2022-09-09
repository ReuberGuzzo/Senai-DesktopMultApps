using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Client.Windows.Funcionalidades
{
    public partial class frmMatriculaAluno : Form
    {
        public frmMatriculaAluno()
        {
            InitializeComponent();
            lblHoje.Text = "Hoje é " + DateTime.Now.ToShortDateString();
        }

                
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            TimeSpan tsQuantidadeDias = DateTime.Now.Date - dtAnoNascimento.Value;
            int idade = (tsQuantidadeDias.Days / 365);

            if (idade > 17)
            {
                lblInserirCategoria.Text = "Adulto";
            }
            else if (idade > 13)
            {
                lblInserirCategoria.Text = "Juvenil B";
            }
            else if (idade > 10)
            {
                lblInserirCategoria.Text = "Juvenil A";
            }
            else if (idade > 7)
            {
                lblInserirCategoria.Text = "Infantil B";
            }
            else if (idade >= 5)
            {
                lblInserirCategoria.Text = "Infantil A";
            }
            else
            {
                lblInserirCategoria.Text = "Não existe categoria";
            }


        }
    }
}
   
    
