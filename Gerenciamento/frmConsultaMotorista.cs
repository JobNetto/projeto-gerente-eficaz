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
            motorista.Codigo = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            motorista.Rua = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            motorista.Bairro = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            motorista.Numero = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            motorista.Complemento = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            motorista.Cidade = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            motorista.Uf = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            motorista.CEP = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            motorista.Telefone1 = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            motorista.Telefone2 = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            motorista.RG = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            motorista.CPF = dataGridView1.CurrentRow.Cells[13].Value.ToString();

            Close();
        }
    }
}
