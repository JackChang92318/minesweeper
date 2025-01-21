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
    public partial class MapSize : Form
    {
        public MapSize()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(numericUpDown1.Value.ToString());
            MainWin fp = (MainWin)this.Owner;
            int bombNumber = fp.bombNumber;
            if (number*number <= bombNumber)
            {
                MessageBox.Show("炸彈塞不下！");
                return;
            }
            //fp.Show();
            this.Hide();
            fp.RestartGame(bombNumber, number);
        }


        private void MapSize_FormClosed(object sender, FormClosedEventArgs e)
        {
            try { this.Owner.Show(); }
            catch { }
        }
    }
}
