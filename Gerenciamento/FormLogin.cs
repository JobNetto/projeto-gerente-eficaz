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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "")
            {
                // Esconde o form login apos clicar em entrar
                this.Hide();

                //Faz dispose automatico do metodo ShowDialog
                using (var T = new FormTelaGeral())
                {
                    T.ShowDialog();
                }
                //Fecha o form
                this.Close();
            }else
            {
                MessageBox.Show("Usuário ou senha inválidos!","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
         
           
        }
    }
}
