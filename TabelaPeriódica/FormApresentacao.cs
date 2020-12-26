using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabelaPeriódica
{
    public partial class FormApresentacao : Form
    {
        public FormApresentacao()
        {
            InitializeComponent();
        }

        private void FormApresentacao_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelCarregamento.Width += 2;

            if(panelCarregamento.Width == 510)
            {
                timer1.Stop();
                timer1.Enabled = false;
                this.Hide();
                Form1 principal = new Form1();
                principal.ShowDialog();
            }
        }
    }
}
