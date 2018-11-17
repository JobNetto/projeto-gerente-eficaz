using Gerenciamento.models;
using Gerenciamento.presenter;
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

namespace Gerenciamento
{
    public partial class FormCadastroCaminhao : FormBase, ICadastroCaminhao
    {
        public PCadastroCaminhao Presenter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Marca { get => txtMarca.Text; set => txtMarca.Text = value; }
        public string Placa { get => txtPlaca.Text; set => txtPlaca.Text = value; }
        public string Codigo { get => txtCodigo.Text; set => txtCodigo.Text = value; }
        public string Modelo { get => txtModelo.Text; set => txtModelo.Text = value; }
        public DateTime AnoFabricacao { get => dtFabricacao.Value; set => dtFabricacao.Value = value; }
        public DateTime AnoModelo { get => dtModelo.Value; set => dtModelo.Value = value; }
        public string Chassi { get => txtChassi.Text; set => txtChassi.Text = value; }
        public string CodRenavam { get => txtCodRenavam.Text; set => txtCodRenavam.Text = value; }
        public CategoriaHabilitacao Categoria
        {
            get
            {
                return new CategoriaHabilitacao
                {
                    CategoriaA = ckABC.Checked,
                    CategoriaB = ckABC.Checked,
                    CategoriaC = ckABC.Checked,
                    CategoriaD = ckD.Checked,
                    CategoriaE = ckE.Checked
                };
            }

            set
            {
                CategoriaHabilitacao c = value;
                ckABC.Checked = c.CategoriaA;
                ckD.Checked = c.CategoriaD;
                ckE.Checked = c.CategoriaE;
            }
        }
        public TipoCombustivel Combustivel
        {
            get
            {
                return new TipoCombustivel
                {
                    Gasolina = rbGasolina.Checked,
                    Diesel = rbDiesel.Checked
                };
            }

            set
            {
                TipoCombustivel c = value;
                rbGasolina.Checked = c.Gasolina;
                rbDiesel.Checked = c.Diesel;
            }
        }
        public string Cor { get =>  txtCor.Text; set => txtCor.Text = value; }
        public double Capacidade { get => double.Parse(txtCapacidade.Text); set => txtCapacidade.Text = value.ToString(); }
        public int Km { get => int.Parse(txtKmInicial.Text); set => value.ToString(); }

        public FormCadastroCaminhao()
        {
            InitializeComponent();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fmr = new frmConsultaCaminhao();
            fmr.ShowDialog();
        }

        private void FormCadastroCaminhao_Load(object sender, EventArgs e)
        {

        }
    }
}
