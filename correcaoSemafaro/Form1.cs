using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace correcaoSemafaro
{
    public partial class Form1 : Form
    {
        Timer timer1 = new Timer();
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void inicia()
        {
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(sema);
            timer1.Enabled = true;

        }
        public void sema(object sender, EventArgs e)
        {
            if (count < 6)
            {
                pictureBox1.Image = Properties.Resources.vermelho_aceso;
                pictureBox4.Image = Properties.Resources.ped_verde;
                count++;
            }
            else if (count < 8)
            {
                pictureBox1.Image = Properties.Resources.vermelho;
                pictureBox2.Image = Properties.Resources.amarelo_aceso;
                pictureBox4.Image = Properties.Resources.ped_vermelho;
                count++;
            }
            else if (count < 13)
            {
                pictureBox2.Image = Properties.Resources.amarelo;
                pictureBox3.Image = Properties.Resources.verde_aceso;
                count++;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.vermelho_aceso;
                pictureBox3.Image = Properties.Resources.verde;
                count = 0;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            inicia();
        }
    }
}
