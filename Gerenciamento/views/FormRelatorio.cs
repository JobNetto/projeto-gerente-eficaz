using Gerenciamento.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento.views
{
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void carrega()
        {
            var r = new Gerenciamento.model.Repository.EntregaRep();

            var ds = r.GetAll(dtInicial.Value.ToString("dd-MM-yyyy") + "." + dtFinal.Value.ToString("dd-MM-yyyy"));

            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument print = new PrintDocument();
            print.DocumentName = "Relatório entregas";
            print.PrintPage += Imprimir;
            PrintPreviewDialog pd = new PrintPreviewDialog();
            pd.Document = print;
            pd.ShowDialog();

        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10);
            float linhaPorPagina = 0;
            float i = 0;
            float contador = 0;
            float margemEsquerda = 20;
            float margemSuperior = 20;
            float alturaFonte = 0;
            alturaFonte = font.GetHeight(e.Graphics);
            linhaPorPagina = e.MarginBounds.Height / alturaFonte;
            e.Graphics.DrawString("Data Inicial", font, Brushes.BlueViolet, margemEsquerda, i);
            e.Graphics.DrawString("Data Final", font, Brushes.BlueViolet, margemEsquerda + 100, i);
            e.Graphics.DrawString("Km", font, Brushes.BlueViolet, margemEsquerda + 200, i);
            e.Graphics.DrawString("Observação", font, Brushes.BlueViolet, margemEsquerda + 300, i);
            contador += 2;
            foreach (DataGridViewRow linha in dataGridView1.Rows)
            {
                if (linha.Cells[0].Value == null) continue;
                i = margemSuperior + contador * alturaFonte;

                //e.Graphics.DrawString(linha.Cells[0].Value.ToString(), font, Brushes.Blue, 10, i = 20);
                //e.Graphics.DrawString(linha.Cells[1].Value.ToString(), font, Brushes.Blue, 30, i = 20);
                e.Graphics.DrawString(DateTime.Parse(linha.Cells[2].Value.ToString()).ToString("dd-MM-yyyy"), font, Brushes.Black, margemEsquerda, i );
                e.Graphics.DrawString(DateTime.Parse(linha.Cells[3].Value.ToString()).ToString("dd-MM-yyyy"), font, Brushes.Black, margemEsquerda  +100, i );
                e.Graphics.DrawString(linha.Cells[4].Value.ToString(), font, Brushes.Black, margemEsquerda + 200, i);
                e.Graphics.DrawString(linha.Cells[5].Value.ToString(), font, Brushes.Black, margemEsquerda + 300, i );
                contador++;

            };
        }
        private void btFiltrar_Click(object sender, EventArgs e)
        {
            carrega();
        }
    }

}
