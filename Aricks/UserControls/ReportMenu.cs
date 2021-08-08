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
    public partial class ReportMenu : UserControl
    {
        private static ReportMenu _instance;
        public static ReportMenu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ReportMenu();
                }
                return _instance;
            }
        }
        public ReportMenu()
        {
            InitializeComponent();
        }

        private void btn_quite_Click(object sender, EventArgs e)
        {
            BuyMenu.Instance.SendToBack();
            BuyMenu.Instance.Hide();
        }

        private void btn_sells_rep_Click(object sender, EventArgs e)
        {
            SellsReport f = new SellsReport();
            f.Show();
        }
    }
}
