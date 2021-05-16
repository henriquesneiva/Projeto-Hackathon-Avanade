using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hackathon_avanaade.foms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DashFuncionarios ds = new DashFuncionarios();

            if (comboBox1.Text == "funcionario")
            {
                ds.Show();
                Hide();
            }else if(comboBox1.Text == "Empresa")
            {
                FormEmpresa dash = new FormEmpresa();
                dash.Show();

                Hide();
            }
            else
            {
                MessageBox.Show("por favor selecione umas das opções Funcionario || Empresa");
            }

            

      
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro cd = new Cadastro();

            cd.Show();

            Hide();
        }
    }
}
