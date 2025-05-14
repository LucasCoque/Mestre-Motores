﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MestreMotores
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja Encerrar?", "ENCERRAR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(resposta == DialogResult.No)
            {
                new FrmLogin().Show();
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
