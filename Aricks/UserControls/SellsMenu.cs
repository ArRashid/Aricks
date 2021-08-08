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
    public partial class SellsMenu : UserControl
    {
        private static SellsMenu _instance;
        public static SellsMenu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SellsMenu();
                }
                return _instance;
            }
        }
        public SellsMenu()
        {
            InitializeComponent();
        }

        private void btn_Quite_Click(object sender, EventArgs e)
        {
            AccountMenu.Instance.Hide();
        }

        private void btn_sellsnew_Click(object sender, EventArgs e)
        {
            SellsVouchar f = new SellsVouchar();
            f.Show();
        }

        private void btn_quite_Click_1(object sender, EventArgs e)
        {
            SellsMenu.Instance.SendToBack();
            SellsMenu.Instance.Hide();
        }
    }
}
