﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hackathon_avanaade.foms
{
    public partial class FormEmpresa : Form
    {
        public FormEmpresa()
        {
            InitializeComponent();
        }

        private void FormEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login lg = new Login();

            lg.Show();

            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadstroFuncionario cadf = new CadstroFuncionario();

            cadf.Show();

            Hide();
        }
    }
}
