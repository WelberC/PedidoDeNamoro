using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PedidoDeNamoro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pbx_coracao.Visible = false;

        }

        private void btn_sim_Click(object sender, EventArgs e)
        {
            Thread.Sleep(15);
            lbl_frase.Text = "Escolheu a melhor resposta!";
            btn_nao.Visible = false;
            btn_sim.Visible = false;
            pbx_coracao.Visible = true;
        }

        private void btn_nao_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;

            Random rnd = new Random();
            x = rnd.Next(10, 300);
            y = rnd.Next(10, 360);

            btn_nao.Location = new Point(x, y);
        }

        
    }
}
