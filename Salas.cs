using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Salas : Form
    {
        public Salas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtComplemento.Text = "";
            txtNom.Text = "";
            txtNumCadei.Text = "";
            txtNumeroPC.Text = "";
            txtPredio.Text = "";
            chkIsLab.Checked = false;
            MessageBox.Show("formulario limpo com sucesso","Mensagem");

        }
    }
}
