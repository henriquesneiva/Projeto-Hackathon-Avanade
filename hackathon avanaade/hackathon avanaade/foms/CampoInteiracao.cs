using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hackathon_avanaade.foms
{
    public partial class CampoInteiracao : Form
    {
        public CampoInteiracao()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login lg = new Login();

            lg.Show();

            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DashFuncionarios dash = new DashFuncionarios();

            dash.Show();

            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Configuracao conf = new Configuracao();

            conf.Show();

            Hide();
        }
    }
}
