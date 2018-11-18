using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento
{
    public partial class FormTelaGeral : Form
    {
        public FormTelaGeral()
        {
            InitializeComponent();
        }

        private void motoristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormCadastroMotorista();
            frm.ShowDialog();
        }


        private void caminhãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormCadastroCaminhao();
            frm.ShowDialog();
        }

        private void viajemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormControleEntrega();
            frm.ShowDialog();
        }

        private void viajemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void caminhãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frmConsultaCaminhao();
            frm.ShowDialog();
        }

        private void motoristaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frmConsultaCaminhao();
            frm.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormListaEntregas();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormCadastroCaminhao();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void motoristasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormCadastroMotorista();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void FormTelaGeral_Load(object sender, EventArgs e)
        {

        }
    }
}
