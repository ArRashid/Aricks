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
    public partial class AccountMenu : UserControl
    {
        private static AccountMenu _instance;
        public static AccountMenu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AccountMenu();
    } return _instance;
            }
        }
        public AccountMenu()
        {
            InitializeComponent();
        }

        private void btn_Quite_Click(object sender, EventArgs e)
        {
            AccountMenu.Instance.Hide();
        }

        private void btn_quite_Click_1(object sender, EventArgs e)
        {
            AccountMenu.Instance.SendToBack();
            AccountMenu.Instance.Hide();
        }

        private void btn_addaccount_Click(object sender, EventArgs e)
        {
           
            AddAccountVouchar f = new AddAccountVouchar();
            f.Show();
           
        }
    }
}
