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
            FormCadastro FC = new FormCadastro();
            FC.Show();
        }
    }
}
