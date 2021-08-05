using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Aricks
{  
    public partial class SellsVouchar : Form
    {
        public bool save = true;
        public bool IsCloseatSave = false;
        public int Add_btn_clicked = 0;
        public int add_loc = 230;
        public int dell_loc = 248;
        public int records = 1;

        public SellsVouchar()
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
        {  //this try block for the vendor name and customer name ----------------------------------------
            try
            {

                OleDbCommand cmd = new OleDbCommand("Select ac_type,full_name from ACCOUNTS", ar.gcon);
                OleDbDataReader reader;
                ar.gcon.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader[1].ToString();
                    if (reader[0].ToString() == "BUYERS") { cb_customer.Items.Add(name); }
                    else if (reader[0].ToString() == "SELLERS") { cb_vendor.Items.Add(name); }
                }

            }
            catch { MessageBox.Show("There was an error in 'GetValue' From Database"); }
            finally { ar.gcon.Close(); }
            //this block for the Voucha id get from db

            try
            {  
                tb_vouchar_id.Text = "1";
                var datatable = new List<int> { };
                OleDbCommand cmd = new OleDbCommand("Select v_id from SELLS", ar.gcon);
                OleDbDataReader reader;
                ar.gcon.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read()) { int a = Convert.ToInt32(reader[0].ToString()); datatable.Add(a); }
                tb_vouchar_id.Text = (datatable.Max() + 1).ToString();
            }
            catch { tb_vouchar_id.Text = "1"; }
            finally { ar.gcon.Close(); }



        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            save = true;


            // Some Validation for the Froms
            try {Convert.ToInt32(tb_vouchar_id.Text); } catch { MessageBox.Show("Vouchar Id Must Be Numeric !");save = false;tb_vouchar_id.Focus(); }
            try //this is for chaking is thare was any same name in database
            {   OleDbCommand namecheck = new OleDbCommand($"Select full_name from ACCOUNTS where full_name = '{cb_customer.Text}'", ar.gcon);
                string dr2;
                ar.gcon.Open();
                try { dr2 = Convert.ToString(namecheck.ExecuteScalar()); }
                catch { MessageBox.Show("Record Name Chaking Field Error:2"); dr2 = ""; }
                if (dr2 != cb_customer.Text || cb_customer.Text == "") { MessageBox.Show("Please Enter A valide name");cb_customer.Focus(); save = false; }
            }
            catch { if (save) { MessageBox.Show("Record Name Chaking Field Error:2"); } }
            finally { ar.gcon.Close(); }




            // From Hare The Saving Data Process Is Started =====================================================
            if (save == true)
            {
                for (int i = records; i > 0; i--)
                {
                    int vouchar = Convert.ToInt32(tb_vouchar_id.Text);

                    dp_date.Format = DateTimePickerFormat.Custom;
                    dp_date.CustomFormat = "yyyy-MM-dd";
                    string date = dp_date.Text;
                    dp_date.CustomFormat = "dd-MM-yyyy";

                    string b_id = tb_bid.Text;
                    string  customer = cb_customer.Text;
                    string vendor = cb_vendor.Text;
                    string trucknoo = tb_truck_no.Text;
                    string remark = tb_truck_agc.Text;
                    double sid = Convert.ToDouble(vouchar);
                    string item = "Not Asing";
                    int quantity = 0;
                    double rate = 0D;
                    double price = 0D;
                    //get the product details From product Controller -----------------------------------------
                    if (i == 6) { sid += 0.6; item = product6.Item; quantity = Convert.ToInt32(product6.Quantity); rate = Convert.ToDouble(product6.Rate); price = Convert.ToDouble(product6.Price); }
                    else if (i == 5) { sid += 0.5; item = product5.Item; quantity = Convert.ToInt32(product5.Quantity); rate = Convert.ToDouble(product5.Rate); price = Convert.ToDouble(product5.Price); }
                    else if (i == 4) { sid += 0.4; item = product4.Item; quantity = Convert.ToInt32(product4.Quantity); rate = Convert.ToDouble(product4.Rate); price = Convert.ToDouble(product4.Price); }
                    else if (i == 3) { sid += 0.3; item = product3.Item; quantity = Convert.ToInt32(product3.Quantity); rate = Convert.ToDouble(product3.Rate); price = Convert.ToDouble(product3.Price); }
                    else if (i == 2) { sid += 0.2; item = product2.Item; quantity = Convert.ToInt32(product2.Quantity); rate = Convert.ToDouble(product2.Rate); price = Convert.ToDouble(product2.Price); }
                    else if (i == 1) { sid += 0.1; item = product1.Item; quantity = Convert.ToInt32(product1.Quantity); rate = Convert.ToDouble(product1.Rate); price = Convert.ToDouble(product1.Price); }
                    else { MessageBox.Show("Error Ocure In get Product Details From Product Controler"); }
                    //submit data to Database ----------------------------------------------------------------------
                    OleDbCommand cmd = new OleDbCommand($"insert into SELLS values({vouchar},{sid},'{date}','{trucknoo}',{b_id},'{customer}','{vendor}','{remark}','{item}',{quantity},{rate},{price})", ar.gcon);
                    try { ar.gcon.Open(); cmd.ExecuteNonQuery(); }
                    catch { MessageBox.Show("ERROR in :submit data to Database "); }
                    finally { ar.gcon.Close(); }

                }
                ClearForm();
                if (IsCloseatSave) { SellsVouchar.ActiveForm.Close(); }
                
                
            }
        }
        // this methoad for clearing the froms  ---------------------------------------------------------------------------------------------
        private void ClearForm()
        {
            tb_vouchar_id.Text = Convert.ToString(Convert.ToInt32(tb_vouchar_id.Text) + 1);
            tb_bid.Text = "";
            tb_truck_no.Text = "";
            cb_customer.Text = "";
            cb_vendor.Text = "";
            tb_truck_agc.Text = "";
            product1.Item = "";
            product1.Quantity = "";
            product1.Rate = "";
            product2.Item = "";
            product2.Quantity = "";
            product2.Rate = "";
            product3.Item = "";
            product3.Quantity = "";
            product3.Rate = "";
            product4.Item = "";
            product4.Quantity = "";
            product4.Rate = "";
            product5.Item = "";
            product5.Quantity = "";
            product5.Rate = "";
            product6.Item = "";
            product6.Quantity = "";
            product6.Rate = "";

            for (int i = Add_btn_clicked; i > 0; i--) { btn_del_Click(null, null); }


            tb_vouchar_id.Focus();

        }

        //this event for add the produuct row -------------------------------------------------------------
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

        // this event delete the product row --------------------------------------------------
        private void btn_del_Click(object sender, EventArgs e)
        {
            records -= 1;

            if (Add_btn_clicked == 1) { add_loc -= 18; btn_del.Hide(); product2.Hide(); }
            else if (Add_btn_clicked == 2) { add_loc -= 20; dell_loc -= 19; product3.Hide(); }
            else if (Add_btn_clicked == 3) { add_loc -= 19; dell_loc -= 19; product4.Hide(); }
            else if (Add_btn_clicked == 4) { add_loc -= 19; dell_loc -= 19; product5.Hide(); }
            else { dell_loc -= 19; product6.Hide(); btn_add.Show(); }

            btn_add.Location = new Point(25, add_loc);
            btn_del.Location = new Point(712, dell_loc);
            Add_btn_clicked = Add_btn_clicked - 1;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            SellsVouchar.ActiveForm.Close();
        }
    }
}