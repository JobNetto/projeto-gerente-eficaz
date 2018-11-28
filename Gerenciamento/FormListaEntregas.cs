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

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //importar
            var entregas = new List<Entrega>();
            openFileDialog1.ShowDialog();
            string caminho = openFileDialog1.FileName;
            openFileDialog1.Dispose();
            string[] lines = System.IO.File.ReadAllLines(caminho);

            foreach (string line in lines)
            {
                var txtLinha = line.Split(';');
                var entrega = new Entrega
                {
                    Id = int.Parse(txtLinha[0]),
                    IdCaminhao = int.Parse(txtLinha[1]),
                    DataSaida = DateTime.Parse(txtLinha[2]),
                    DataChegada = DateTime.Parse(txtLinha[3]),
                    KmFinal = int.Parse(txtLinha[4]),
                    Observacao = txtLinha[5]
                };
                entregas.Add(entrega);
            }
            dataGridView1.DataSource = entregas;

        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exportar
            if (dataGridView1.DataSource != null)
            {
                folderBrowserDialog1.ShowDialog();
                string caminho = folderBrowserDialog1.SelectedPath;
                folderBrowserDialog1.Dispose();
                
                var entregas = new List<Entrega>();

                foreach (DataGridViewRow linha in dataGridView1.Rows)
                {
                    var entrega = new Entrega
                    {
                        Id = int.Parse(linha.Cells[0].Value.ToString()),
                        IdCaminhao = int.Parse(linha.Cells[1].Value.ToString()),
                        DataSaida = DateTime.Parse(linha.Cells[2].Value.ToString()),
                        DataChegada = DateTime.Parse(linha.Cells[3].Value.ToString()),
                        KmFinal = int.Parse(linha.Cells[4].Value.ToString()),
                        Observacao = linha.Cells[5].Value.ToString()
                    };
                    entregas.Add(entrega);
                }

                var listaString = new List<string>();

                foreach (var ent in entregas)
                {
                    string entrega = $@"{ent.Id};{ent.IdCaminhao};{ent.DataSaida.ToString("dd-MM-yyyy")};{ent.DataChegada.Value.ToString("dd-MM-yyyy")};{ent.KmFinal};{ent.Observacao}";

                    listaString.Add(entrega);
                }

                System.IO.File.WriteAllLines(caminho + "/arquivo.txt", listaString);
                MessageBox.Show("Exportado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tXTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
