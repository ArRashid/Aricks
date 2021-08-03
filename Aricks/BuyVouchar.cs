using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Aricks
{
    public partial class BuyVouchar : Form
    {

        public int Add_btn_clicked = 0;
        public int add_loc = 230;
        public int dell_loc = 248;
        public int records = 1;

        public BuyVouchar()
        {
            InitializeComponent();
            GetvlueFromDB();
            btn_del.Hide();
            product2.Hide();
            product3.Hide();
            product4.Hide();
            product5.Hide();
            product6.Hide();


        }
        private void GetvlueFromDB()  // this is for ato id genarate in ADD account Vouchar
        {
            try
            {

                OleDbCommand cmd = new OleDbCommand("Select ac_type,full_name from ACCOUNTS", ar.gcon);
                OleDbDataReader reader;
                ar.gcon.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader[1].ToString();
                    if (reader[0].ToString() == "SELLERS") { cb_vendor.Items.Add(name); }
                    else if (reader[0].ToString() == "BUYERS") { cb_cutomer.Items.Add(name); }
                }

            }
            catch { MessageBox.Show("There was an error in 'GetValue' From Database"); }
            finally { ar.gcon.Close(); }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            for (int i = records; i > 0; i--)
            {
                MessageBox.Show("Total record is :" + records);
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Add_btn_clicked = Add_btn_clicked + 1;
            records += 1;

            if (Add_btn_clicked == 1) { add_loc = add_loc + 18; product2.Show(); btn_del.Show(); }
            else if (Add_btn_clicked == 2) { add_loc = add_loc + 20; product3.Show(); dell_loc = dell_loc + 20; }
            else if (Add_btn_clicked == 3) { add_loc = add_loc + 19; product4.Show(); dell_loc = dell_loc + 19; }
            else if (Add_btn_clicked == 4) { add_loc = add_loc + 19; product5.Show(); dell_loc = dell_loc + 19; }
            else { btn_add.Hide(); product6.Show(); dell_loc = dell_loc + 19; }
            btn_add.Location = new Point(25, add_loc);
            btn_del.Location = new Point(712, dell_loc);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            records -= 1;

            if (Add_btn_clicked == 1) { add_loc -= 18; btn_del.Hide(); product2.Hide(); }
            else if (Add_btn_clicked == 2) { add_loc -= 20; dell_loc -= 19; product3.Hide(); }
            else if (Add_btn_clicked == 3) { add_loc -= 19; dell_loc -= 19; product4.Hide(); }
            else if (Add_btn_clicked == 4) { add_loc -= 19; dell_loc -= 19; product5.Hide(); }
            else {  dell_loc -= 19; product6.Hide(); btn_add.Show(); }

            btn_add.Location = new Point(25, add_loc);
            btn_del.Location = new Point(712, dell_loc);
            Add_btn_clicked = Add_btn_clicked - 1;            
        }
    }
}