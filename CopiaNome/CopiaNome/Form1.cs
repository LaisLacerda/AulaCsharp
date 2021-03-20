using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopiaNome
{
    public partial class frmCopiar : Form
    {
        public frmCopiar()
        {
            InitializeComponent();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            lblCopiar.Visible = true;
            lblCopiar.Text = txtNome.Text + " " + txtSobrenome.Text;

        }

        private void lblSobrenome_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSobrenome.Clear();
            lblCopiar.Visible = false;
        }
    }
}
