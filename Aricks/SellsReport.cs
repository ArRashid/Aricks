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
    public partial class SellsReport : Form
    {
        int xacc = 160;
        int totalRecord = 0;
        int totalPrice;
        
        public SellsReport()
        {
            InitializeComponent();
        }

        private void btn_print_pre_Click(object sender, EventArgs e)
        {
            
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            
        }
       

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Sells Report", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, 340,5);
            e.Graphics.DrawString("Account : Some One's Account", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, 10,60 );
            e.Graphics.DrawString("Reporting Date : 22/11/2021", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, 500, 60);
            e.Graphics.DrawString("From Date : 22/11/2020", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, 10,90);
            e.Graphics.DrawString("Upto Date : 22/11/2021", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, 500, 90);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, 0, 110);
            e.Graphics.DrawString("DATE    |", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, 10, 130);
            e.Graphics.DrawString("TRUCK   |", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, 160, 130);
            e.Graphics.DrawString("ITEM    |", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, 310, 130);
            e.Graphics.DrawString("QUNTITY |", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, 450, 130);
            e.Graphics.DrawString("RATE    |", new Font("Arial", 18, FontStyle.Bold), Brushes.Black,600 , 130);
            e.Graphics.DrawString("PRICE   |", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, 720, 130);
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, 0, 150);


            OleDbCommand cmd = new OleDbCommand("Select * From SELLS",ar.gcon);
            OleDbDataReader reader;

            ar.gcon.Open();

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                xacc += 20;
                totalPrice += 1;
                totalRecord += 1;
                //totalPrice += Convert.ToInt32(reader["price"]);
                if (totalRecord < 40)
                {

                    e.Graphics.DrawString(Convert.ToString("25-6-200"), new Font("Arial", 12, FontStyle.Italic), Brushes.Black, 10, xacc);
                    e.Graphics.DrawString(Convert.ToString(reader["truck_no"]), new Font("Arial", 12, FontStyle.Italic), Brushes.Black, 160, xacc);
                    e.Graphics.DrawString(Convert.ToString(reader["item"]), new Font("Arial", 12, FontStyle.Italic), Brushes.Black, 310, xacc);
                    e.Graphics.DrawString(Convert.ToString(reader["quantity"]), new Font("Arial", 12, FontStyle.Italic), Brushes.Black, 450, xacc);
                    e.Graphics.DrawString(Convert.ToString(reader["rate"]), new Font("Arial", 12, FontStyle.Italic), Brushes.Black, 600, xacc);
                    e.Graphics.DrawString(Convert.ToString(reader["price"]), new Font("Arial", 12, FontStyle.Italic), Brushes.Black, 720, xacc);
                    e.Graphics.DrawString("____________________________________________________________________________________________________", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, 0, xacc - 7);
                }
                else
                {

                    e.Graphics.DrawString(Convert.ToString("25-6-200"), new Font("Arial", 12, FontStyle.Italic), Brushes.Black, 10, xacc);
                    e.Graphics.DrawString(Convert.ToString(reader["truck_no"]), new Font("Arial", 12, FontStyle.Italic), Brushes.Black, 160, xacc);
                    e.Graphics.DrawString(Convert.ToString(reader["item"]), new Font("Arial", 12, FontStyle.Italic), Brushes.Black, 310, xacc);
                    e.Graphics.DrawString(Convert.ToString(reader["quantity"]), new Font("Arial", 12, FontStyle.Italic), Brushes.Black, 450, xacc);
                    e.Graphics.DrawString(Convert.ToString(reader["rate"]), new Font("Arial", 12, FontStyle.Italic), Brushes.Black, 600, xacc);
                    e.Graphics.DrawString(Convert.ToString(reader["price"]), new Font("Arial", 12, FontStyle.Italic), Brushes.Black, 720, xacc);
                    e.Graphics.DrawString("____________________________________________________________________________________________________", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, 0, xacc - 7);

                    totalRecord = 0;
                }

            }
            e.Graphics.DrawString("========================================================================================================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, 0, xacc +50);

            e.Graphics.DrawString("     Total Price : " , new Font("Arial", 18, FontStyle.Regular), Brushes.Black, 500, xacc+70);
            e.Graphics.DrawString("      Old balnce : 0000", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, 500, xacc + 100);
            e.Graphics.DrawString("--------------------------------", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, 500, xacc + 110);
            e.Graphics.DrawString("Current Balance  : 15001451", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, 500, xacc + 140);

            ar.gcon.Close();

        }
    }
}
