using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class YouWin__ : Form
    {
        int length;
        int bombNumber;
        int useTime;
        public YouWin__(int l,int b,int u)
        {
            length = l;
            bombNumber = b;
            useTime = u;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string names = textBox1.Text;
            if(names.Length==0)
            {
                MessageBox.Show("留下你的尊姓大名吧！！");
                return;
            }
            FileStream fp2 = new FileStream("Achievements.txt", FileMode.Append);
            StreamWriter fp = new StreamWriter(fp2);
            fp.Write(names + " " + length + " " + bombNumber + " " + useTime + "\r\n");
            fp.Close();
            MainWin fps = (MainWin)this.Owner;
            //this.Close();
            this.Hide();
            fps.RestartGame(bombNumber, length);
        }

        private void Win___FormClosed(object sender, FormClosedEventArgs e)
        {
            /*try { this.Owner.Show(); }
            catch { }*/
        }

        private void Win___Load(object sender, EventArgs e)
        {

        }
    }
}
