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
    public partial class BuyMenu : UserControl
    {
        private static BuyMenu _instance;
        public static BuyMenu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BuyMenu();
                }
                return _instance;
            }
        }
        public BuyMenu()
        {
            InitializeComponent();
        }

        private void btn_quite_Click(object sender, EventArgs e)
        {
            BuyMenu.Instance.SendToBack();
            BuyMenu.Instance.Hide();
        }

        private void btn_buy_add_Click(object sender, EventArgs e)
        {
            BuyVouchar f = new BuyVouchar();
            f.Show();
        }
    }
}
