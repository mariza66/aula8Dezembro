﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula8Dezembro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botaoEmviar_Click(object sender, EventArgs e)
        {
            mensagemFinal.Text = "O nome digitado foi:" + input.Text;
        }
    }
}
