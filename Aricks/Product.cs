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
    public partial class Product : UserControl
    {
        public static int CountProduct = 0;
        public Product()
        {
            InitializeComponent();
            CountProduct = CountProduct + 1;
            this.tb_seno.Text = CountProduct.ToString(); 


        }




        //--------------- Calculate the price -------------------------------
        private void tb_rate_taxtChanged(object sender, EventArgs e)
        {
            tb_price.Text = CheckPrice();
        }
        private void tb_qty_change(object sender, EventArgs e)
        {
            tb_price.Text = CheckPrice();
        }

        private string CheckPrice()
        {
            double rate = 0;
            double quantity = 0;
            double reslt = 0;
            try
            {
                quantity = Convert.ToDouble(tb_qtty.Text);

                rate = Convert.ToDouble(tb_rate.Text);
            }
            catch { }
            finally { reslt = quantity * rate; }


            return Convert.ToString(reslt);
        }
        //--------------- gettar settar for fields --------------------
        public String Seno
        {
            get
            {
                return tb_seno.Text;
            }

            set
            {
                tb_seno.Text = value;
            }
        }

        public String Item
        {
            get
            {
                return cb_item.Text;
            }

            set
            {
                cb_item.Text = value;
            }
        }

        public String Quantity
        {
            get
            {
                return tb_qtty.Text;
            }

            set
            {
                tb_qtty.Text = value;
            }
        }
        public String Rate
        {
            get
            {
                return tb_rate.Text;
            }

            set
            {
                tb_rate.Text = value;
            }
        }
        public String Price
        {
            get
            {
                return tb_price.Text;
            }

            set
            {
                tb_price.Text = value;
            }
        }

       
    }
}
