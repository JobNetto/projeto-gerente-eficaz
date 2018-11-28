using Gerenciamento.model.Repository;
using Gerenciamento.models;
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
    public partial class frmConsultaCaminhao : Form
    {
        public frmConsultaCaminhao()
        {
            InitializeComponent();
        }

        public Caminhao caminhao { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            var r = new CaminhaoRep();

            var ds = r.GetAll(maskedTextBox1.Text);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                caminhao = new Caminhao();

                caminhao.Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                caminhao.Marca = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                caminhao.Placa = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                caminhao.Codigo = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                caminhao.Modelo = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                caminhao.AnoFabricacao = DateTime.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                caminhao.AnoModelo = DateTime.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                caminhao.Chassi = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                caminhao.CodRenavam = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                caminhao.Cor = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                caminhao.Capacidade = decimal.Parse(dataGridView1.CurrentRow.Cells[10].Value.ToString());
                caminhao.KmRodado = int.Parse(dataGridView1.CurrentRow.Cells[11].Value.ToString());
            }

            Close();
        }
    }
}
