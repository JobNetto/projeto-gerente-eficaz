using Gerenciamento.model.Repository;
using Gerenciamento.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gerenciamento.presenter;
using Gerenciamento.model.Classes;

namespace Gerenciamento
{
    public partial class FormControleEntrega : FormBase, ICadastroEntrega
    {
        public int IdCaminhao
        {
            get
            {
                return (int)comboBox1.SelectedValue;
            }

            set
            {
                comboBox1.SelectedValue = value;
            }
        }

        public DateTime DataSaida
        {
            get
            {
                return dtSaida.Value;
            }

            set
            {
                dtSaida.Value = value;
            }
        }

        public DateTime? DataChegada
        {
            get
            {
                return dtChegada.Value;
            }

            set
            {
                var s = value;
                dtChegada.Value = s.Value;
            }
        }

        public int KmFinal
        {
            get
            {
                return (int)numericUpDown1.Value;
            }

            set
            {
                numericUpDown1.Value = value;
            }
        }

        public string Observacao
        {
            get
            {
                return textBox1.Text;
            }

            set
            {
                textBox1.Text = value;
            }
        }

        public PCadastroEntrega Presenter { get; set; }
       

        public FormControleEntrega()
        {
            InitializeComponent();
            Presenter = new PCadastroEntrega(this);
        }

        private void FormControleEntrega_Load(object sender, EventArgs e)
        {
            var r = new CaminhaoRep();

            comboBox1.DisplayMember = "Placa";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = r.GetAll("").Tables[0];
        }

        public Entrega entrega { get; set; } 
        private void btGravar_Click(object sender, EventArgs e)
        {
            if (Alterar)
            {
                Presenter.Alterar(entrega.Id);
            }
            else
            {
                Presenter.Salvar();
            }
        }
        public bool Alterar { get; set; }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
