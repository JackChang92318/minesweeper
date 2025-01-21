using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class BS : Form
    {
        public BS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(numericUpDown1.Value.ToString());
            MainWin fp = (MainWin)this.Owner;
            int length = fp.length;
            if (number >= length * length)
            {
                MessageBox.Show("炸彈塞不下！");
                return;
            }
            //fp.Show();
            this.Hide();
            fp.RestartGame(number, length);
            
        }


        private void NB_Load(object sender, EventArgs e)
        {

        }

        private void NB_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            try { this.Owner.Show(); }
            catch { }
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
