using Gerenciamento.model.Repository;
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
    public partial class FormControleEntrega : FormBase
    {
        public FormControleEntrega()
        {
            InitializeComponent();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmConsultaEntrega();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void FormControleEntrega_Load(object sender, EventArgs e)
        {
            var r = new CaminhaoRep();

            comboBox1.DisplayMember = "Placa";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = r.GetAll("").Tables[0];
        }
    }
}
