using System;
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
    public partial class limpar : Form
    {
        public limpar()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            tela.AppendText("\r\n" + "Pressionei a tecla:"+ e.KeyCode);
            tela.AppendText("\r\n" + "\t" + "Código da tecla:" + ((int)e.KeyCode));
        }
    }
}
