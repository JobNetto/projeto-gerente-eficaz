﻿using Gerenciamento.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gerenciamento.models;
using Gerenciamento.presenter;

namespace Gerenciamento
{
    public partial class FormCadastroMotorista : FormBase, ICadastroMotorista
    {
        public FormCadastroMotorista()
        {
            InitializeComponent();
            Presenter = new PCadastroMorista(this);
        }

        public PCadastroMorista Presenter { get; set; }


        public string Nome
        {
            get
            {
                return txtNome.Text;
            }

            set
            {
                txtNome.Text = value;
            }
        }

        public string Codigo
        {
            get
            {
                return txtCodigo.Text;
            }

            set
            {
                txtCodigo.Text = value;
            }
        }

        public string Rua
        {
            get
            {
                return txtRua.Text;
            }

            set
            {
                txtRua.Text = value;
            }
        }

        public string Bairro
        {
            get
            {
                return txtBairro.Text;
            }

            set
            {
                txtBairro.Text = value;
            }
        }

        public string Numero
        {
            get
            {
                return txtNumero.Text;
            }

            set
            {
                txtNumero.Text = value;
            }
        }

        public string Complemento
        {
            get
            {
                return txtComplemento.Text;
            }

            set
            {
                txtComplemento.Text = value;
            }
        }

        public string Cidade
        {
            get
            {
                return txtCidade.Text;
            }

            set
            {
                txtCidade.Text = value;
            }
        }

        public string Uf
        {
            get
            {
                return txtUF.Text;
            }

            set
            {
                txtUF.Text = value;
            }
        }

        public string CEP
        {
            get
            {
                return txtCEP.Text;
            }

            set
            {
                txtCEP.Text = value;
            }
        }

        public string Telefone1
        {
            get
            {
                return txtTelefone1.Text;
            }

            set
            {
                txtTelefone1.Text = value;
            }
        }

        public string Telefone2
        {
            get
            {
                return txtTelefone2.Text;
            }

            set
            {
                txtTelefone2.Text = value;
            }
        }

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

        public string RG
        {
            get
            {
                return txtRG.Text;
            }

            set
            {
                txtRG.Text = value;
            }
        }

        public string CPF
        {
            get
            {
                return txtCPF.Text;
            }

            set
            {
                txtCPF.Text = value;
            }
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmConsultaMotorista();
            frm.ShowDialog();
            this.Motorista = frm.motorista;
            if (Motorista != null)
                CarregaComponentes();
        }

        private void CarregaComponentes()
        {
            txtNome.Text = Motorista.Nome;
            txtCodigo.Text = Motorista.Codigo;
            txtRua.Text = Motorista.Rua;
            txtBairro.Text = Motorista.Bairro;
            txtCidade.Text = Motorista.Cidade;
            txtUF.Text = Motorista.Uf;
            txtCPF.Text = Motorista.CPF;
            txtRG.Text = Motorista.RG;
            txtTelefone1.Text = Motorista.Telefone1;
            txtTelefone2.Text = Motorista.Telefone2;
            txtCEP.Text = Motorista.CEP;
            txtNumero.Text = Motorista.Numero;
            txtComplemento.Text = Motorista.Complemento;

        }

        private Motorista Motorista { get; set; }

        private void btGravar_Click(object sender, EventArgs e)
        {
            Presenter.Gravar();
            MessageBox.Show("Gravado Com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presenter.Salvar(this.Motorista.Id);
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Motorista = new Motorista();
            CarregaComponentes();
        }
    }
}
