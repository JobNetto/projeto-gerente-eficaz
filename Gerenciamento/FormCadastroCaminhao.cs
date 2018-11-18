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
        public PCadastroCaminhao Presenter { get; set; }

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
        public string Cor { get => txtCor.Text; set => txtCor.Text = value; }
        public decimal Capacidade { get => npCapacidade.Value; set => npCapacidade.Value = value; }
        public int Km { get { return Convert.ToInt32(npKmRodado.Value); }set { npKmRodado.Value = value; } }

        public FormCadastroCaminhao()
        {
            InitializeComponent();
            Presenter = new PCadastroCaminhao(this);
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmConsultaCaminhao();
            frm.ShowDialog();
            this.caminhao = frm.caminhao;
            if (caminhao != null)
                CarregaComponentes();
        }

        private void FormCadastroCaminhao_Load(object sender, EventArgs e)
        {

        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presenter.Salvar(caminhao.Id);
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caminhao = new Caminhao();
            caminhao.AnoFabricacao = DateTime.Now;
            caminhao.AnoModelo = DateTime.Now;
            CarregaComponentes();
        }

        private void CarregaComponentes()
        {
            txtMarca.Text = caminhao.Marca;
            txtPlaca.Text = caminhao.Placa;
            txtCodigo.Text = caminhao.Codigo;
            txtModelo.Text = caminhao.Modelo;
            dtFabricacao.Value = caminhao.AnoModelo;
            dtModelo.Value = caminhao.AnoFabricacao;
            txtChassi.Text = caminhao.Chassi;
            txtCodRenavam.Text = caminhao.CodRenavam;
            txtCor.Text = caminhao.CodRenavam;
            npCapacidade.Value = caminhao.Capacidade;
            npKmRodado.Value = caminhao.KmRodado;
        }

        private Caminhao caminhao { get; set; }

        private void btGravar_Click(object sender, EventArgs e)
        {
            Presenter.Gravar();
            MessageBox.Show("Dados gravados com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
