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
            // Adding User Control in Panel And init main User Control 
            content_panel.Controls.Add(MainMenu.Instance);
            content_panel.Controls.Add(AccountMenu.Instance);
            content_panel.Controls.Add(BuyMenu.Instance);
            content_panel.Controls.Add(SellsMenu.Instance);

            btn_main_Click(null, null);
            


        }

        private void content_panel_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            if (indexofuc("AccountMenu") > 0)
            {
                AccountMenu.Instance.Dock = DockStyle.Fill;
                AccountMenu.Instance.Show();
                AccountMenu.Instance.BringToFront();
            }
            else
            {
                content_panel.Controls.Add(AccountMenu.Instance);
                AccountMenu.Instance.Dock = DockStyle.Fill;
                AccountMenu.Instance.Show();
                AccountMenu.Instance.BringToFront();
               
            }
        }

       

        private void btn_Buy_Click(object sender, EventArgs e)
        {

            if (indexofuc("BuyMenu") > 0)
            {
               BuyMenu.Instance.Dock = DockStyle.Fill;
                BuyMenu.Instance.Show();
                BuyMenu.Instance.BringToFront();
            }
            else
            {
                content_panel.Controls.Add(BuyMenu.Instance);
                BuyMenu.Instance.Dock = DockStyle.Fill;
                BuyMenu.Instance.Show();
                BuyMenu.Instance.BringToFront();
            }
        }

        private void btn_Sells_click(object sender, EventArgs e)
        {

            if (indexofuc("SellsMenu") > 0)
            {
                SellsMenu.Instance.Dock = DockStyle.Fill;
                SellsMenu.Instance.Show();
                SellsMenu.Instance.BringToFront();
            }
            else
            {
                content_panel.Controls.Add(SellsMenu.Instance);
                SellsMenu.Instance.Dock = DockStyle.Fill;
                SellsMenu.Instance.Show();
                SellsMenu.Instance.BringToFront();
            }
            
          
        }

        // this Funstinon for check the index of User Control
        public int indexofuc(String NameOfUserControl)
        {
            int ined = content_panel.Controls.IndexOfKey(NameOfUserControl);
            return ined;
        }

        public void btn_main_Click(object sender, EventArgs e)
        {
            if (indexofuc("MainMenu") > 0)
            {
                MainMenu.Instance.Dock = DockStyle.Fill;
                MainMenu.Instance.Show();
                MainMenu.Instance.BringToFront();
            }
            else
            {
                content_panel.Controls.Add(AccountMenu.Instance);
                MainMenu.Instance.Dock = DockStyle.Fill;
                MainMenu.Instance.Show();
                MainMenu.Instance.BringToFront();
               
            }
        }
    }
}
