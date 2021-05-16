using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hackathon_avanaade.foms
{
    public partial class DashFuncionarios : Form
    {
        public DashFuncionarios()
        {
            InitializeComponent();
        }

        private void Cronometro()
        {
           
        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Configuracao conf = new Configuracao();

            conf.Show();

            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CampoInteiracao ci = new CampoInteiracao();

            ci.Show();

            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login lg = new Login();

            lg.Show();

            Hide();
        }



        private void DashFuncionarios_Load(object sender, EventArgs e)
        {
      
        }
    }
}
