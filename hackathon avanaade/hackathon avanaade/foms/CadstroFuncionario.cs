using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hackathon_avanaade.foms
{
    public partial class CadstroFuncionario : Form
    {
        public CadstroFuncionario()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login lg = new Login();

            lg.Show();

            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEmpresa femp = new FormEmpresa();

            femp.Show();

            Hide();
        }
    }
}
