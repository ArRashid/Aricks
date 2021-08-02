using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aricks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bacupsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
           
            mainpanel.Controls.Add(UserControl1.Instance);
           
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
                    }

        private void button1_Click_2(object sender, EventArgs e)
        {
            mainpanel.Controls.Add(UserControl1.Instance);
        }
    }
}
