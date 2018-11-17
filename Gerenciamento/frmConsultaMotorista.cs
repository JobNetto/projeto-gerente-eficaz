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
    public partial class frmConsultaMotorista : Form
    {
        public frmConsultaMotorista()
        {
            InitializeComponent();
        }
        public Gerenciamento.models.Motorista motorista { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            var r = new Repository.MotoristaRep();

            var ds = r.GetAll(txtNomeMotorista.Text);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtNomeMotorista_TextChanged(object sender, EventArgs e)
        {
            var r = new Repository.MotoristaRep();

            var ds = r.GetAll(txtNomeMotorista.Text);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            motorista = new models.Motorista();
            motorista.Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            motorista.Nome = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
