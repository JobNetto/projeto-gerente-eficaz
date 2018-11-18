using Gerenciamento.model.Classes;
using Gerenciamento.model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gerenciamento
{
    public partial class FormListaEntregas : Form
    {
        public FormListaEntregas()
        {
            InitializeComponent();
        }
        EntregaRep r = new EntregaRep();

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControleEntrega frm = new FormControleEntrega();

            frm.ShowDialog();
            frm.Dispose();
            Carrega();


        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var entrega = new Entrega
            {
                Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()),
                IdCaminhao = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()),
                DataSaida = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()),
                DataChegada = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()),
                KmFinal = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()),
                Observacao = dataGridView1.CurrentRow.Cells[5].Value.ToString()
            };
            FormControleEntrega frm = new FormControleEntrega();
            frm.entrega = entrega;
            frm.Alterar = true;
            frm.ShowDialog();
            frm.Dispose();
            Carrega();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormListaEntregas_Load(object sender, EventArgs e)
        {
            Carrega();
        }
        public void Carrega()
        {


            dataGridView1.DataSource = r.GetAll("").Tables[0];
        }
    }
}
