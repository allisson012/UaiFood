﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UaiFood.View
{
    public partial class TelaCadastroRestaurante : Form
    {
        public TelaCadastroRestaurante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }

        private void TelaCadastroRestaurante_Load(object sender, EventArgs e)
        {

        }

        private void txtRepeteSenha_TextChanged(object sender, EventArgs e)
        {

        }

        public static implicit operator TelaCadastroRestaurante(TelaCadastro v)
        {
            throw new NotImplementedException();
        }
    }
}
