using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace Aricks
{
    public partial class AddAccountVouchar : Form
    {
        //this variable for closing the from after saave 
        public bool CloseatSave = false;



        public AddAccountVouchar()
        {
            InitializeComponent();
            GetIdFromDB();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            AddAccountVouchar.ActiveForm.Close();
        }

        private void AddAccountVouchar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.AcType' table. You can move, or remove it, as needed.
            this.acTypeTableAdapter.Fill(this.databaseDataSet.AcType);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // save the from s data
            // 
            bool save = true;
            long acid = 0;
            String type = cb_ac_type.Text;
            string full_name = tb_full_name.Text;

            String mobile = tb_mobile.Text;
            String email = tb_email.Text;
            String bankac = tb_bank_ac.Text;
            String bankifc = tb_bank_ifc.Text;
            String address = tb_address.Text;
            long opnenbl = 0;

            /// this is for some validation 
            try { acid = Convert.ToInt64(tb_ac_id.Text); } catch { MessageBox.Show("ID Field Is Recuired a Number value"); tb_ac_id.Focus(); tb_ac_id.Clear(); save = false; }
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------      
            try //this is for chaking is thare was any same ID in database
            {
                OleDbCommand check = new OleDbCommand($"Select ac_id from ACCOUNTS where ac_id = {tb_ac_id.Text};", ar.gcon);
                int dr;
                ar.gcon.Open();
                dr = Convert.ToInt32(check.ExecuteScalar());
                if (dr > 0) { MessageBox.Show("This ID IS Alredy Regestrred Try another ID"); tb_ac_id.Focus(); save = false; }
            }
            catch { if (save) { MessageBox.Show("Record ID Chaking Field"); } }
            finally { ar.gcon.Close(); }
            //--------------------------------------------------------------------------------------------------------
            if (type == "") { MessageBox.Show("You Must Enter The Type of Account"); cb_ac_type.Text = ""; cb_ac_type.Focus(); save = false; }
            if (full_name == "") { MessageBox.Show("You Must Enter The Full Name"); tb_full_name.Focus(); save = false; }
            //--------------------------------------------------------------------------------------------------------------------
            try //this is for chaking is thare was any same name in database
            {
                OleDbCommand namecheck = new OleDbCommand($"Select full_name from ACCOUNTS where full_name = '{full_name}'", ar.gcon);
                string dr2;
                ar.gcon.Open();
                try { dr2 = Convert.ToString(namecheck.ExecuteScalar()); }
                catch { MessageBox.Show("Record Name Chaking Field Error:2"); dr2 = ""; }
                if (dr2 == full_name) { MessageBox.Show("This Name IS Alredy Regestrred Try another ID"); tb_full_name.Focus(); save = false; }
            }
            catch { if (save) { MessageBox.Show("Record Name Chaking Field Error:2"); } }
            finally { ar.gcon.Close(); }
            //---------------------------------------------------------------------------------------------------------------------------------------------------------
            try { if (tb_opening_balance.Text != "") { opnenbl = Convert.ToInt64(tb_opening_balance.Text); } } catch { MessageBox.Show("Opening Blance Must is Numeric Value"); tb_opening_balance.Focus(); save = false; }




            //this opto]in for savig The items in data base
            if (save)
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand($"Insert into ACCOUNTS values({acid},'{type}','{full_name}','{mobile}','{email}','{bankac}','{bankifc}',{opnenbl},'{address}')", ar.gcon);
                    ar.gcon.Open();
                    cmd.ExecuteNonQuery();
                    ar.gcon.Close();
                    ClearForm();
                    if (CloseatSave) { AddAccountVouchar.ActiveForm.Close(); }
                }
                catch { MessageBox.Show("Data Saving Process is Field Error:1"); }

            }


        }


        private void GetIdFromDB()  // this is for ato id genarate in ADD account Vouchar
        {
            try
            {
                var datatable = new List<int> { };
                OleDbCommand cmd = new OleDbCommand("Select ac_id from ACCOUNTS", ar.gcon);
                OleDbDataReader reader;
                ar.gcon.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read()) { int a = Convert.ToInt32(reader[0].ToString()); datatable.Add(a); }
                tb_ac_id.Text = (datatable.Max() + 1).ToString();
            }
            catch { tb_ac_id.Text = "1"; MessageBox.Show("Threwas an error in auto ID"); }
            finally { ar.gcon.Close(); }
        }


        private void ClearForm() //this method for clear the froms
        {
            GetIdFromDB();
            cb_ac_type.Text = "";
            tb_full_name.Text = "";

            tb_mobile.Text = "";
            tb_email.Text = "";
            tb_bank_ac.Text = "";
            tb_bank_ifc.Text = "";
            tb_opening_balance.Text = "";
            tb_address.Text = "";
            tb_ac_id.Focus();

        }
    }
}
