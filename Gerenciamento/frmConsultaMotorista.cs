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

        }
    }
}
