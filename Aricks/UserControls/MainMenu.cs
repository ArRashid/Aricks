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
    public partial class MainMenu : UserControl
    {
        private static MainMenu _instance;
        public static MainMenu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MainMenu();
    } return _instance;
            }
        }
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
