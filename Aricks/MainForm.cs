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
    public partial class MainForm : Form
    {


        public MainForm()
        {

            InitializeComponent();
            // Adding Main menu User COntrol at Menu Panel
            //menu_panel.Controls.Add(MainMenu.Instance);
            //MainMenu.Instance.Dock = DockStyle.Fill;

        }

        private void content_panel_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            content_panel.Controls.Clear();
            content_panel.Controls.Add(AccountMenu.Instance);
            AccountMenu.Instance.Dock = DockStyle.Fill;
            AccountMenu.Instance.Show();
        }

       

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            content_panel.Controls.Clear();
            content_panel.Controls.Add(BuyMenu.Instance);
            BuyMenu.Instance.Dock = DockStyle.Fill;
            BuyMenu.Instance.Show();
        }

        private void btn_Sells_click(object sender, EventArgs e)
        {
            content_panel.Controls.Clear();
            content_panel.Controls.Add(SellsMenu.Instance);
            SellsMenu.Instance.Dock = DockStyle.Fill;
            SellsMenu.Instance.Show();
        }
    }
}
