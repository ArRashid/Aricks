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
        public BuyVouchar()
        {
            InitializeComponent();
            GetvlueFromDB();
        }
        private void GetvlueFromDB()  // this is for ato id genarate in ADD account Vouchar
        {
            try
            {
                
                OleDbCommand cmd = new OleDbCommand("Select ac_type,frist_name,last_name from ACCOUNTS", ar.gcon);
                OleDbDataReader reader;
                ar.gcon.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read()) { string name = reader[1].ToString() +" "+ reader[2].ToString();
                    if (reader[0].ToString() == "SELLERS") {cb_vendor.Items.Add(name); }
                    else if (reader[0].ToString() == "BUYERS") { cb_cutomer.Items.Add(name); } }
               
            }
            catch { MessageBox.Show("There was an error in 'GetValue' From Database"); }
            finally { ar.gcon.Close(); }
        }
    }
}
