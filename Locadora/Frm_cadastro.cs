﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora
{
    public partial class Frm_cadastro : Form
    {
        public Frm_cadastro()
        {
            InitializeComponent();
        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {
            tb_email.TextAlign = HorizontalAlignment.Left;
        }

        private void tb_senha_TextChanged(object sender, EventArgs e)
        {
            tb_senha.TextAlign = HorizontalAlignment.Left;
        }

        private void tb_confsenha_TextChanged(object sender, EventArgs e)
        {
            tb_confsenha.TextAlign = HorizontalAlignment.Left;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Frm_locadora principal = new Frm_locadora();
            principal.ShowDialog();
        }
    }
}
