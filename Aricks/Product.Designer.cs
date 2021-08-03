
namespace Aricks
{
    partial class Product
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_qtty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_item = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_rate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_seno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_qtty
            // 
            this.tb_qtty.Location = new System.Drawing.Point(316, 0);
            this.tb_qtty.Name = "tb_qtty";
            this.tb_qtty.Size = new System.Drawing.Size(82, 20);
            this.tb_qtty.TabIndex = 0;
            this.tb_qtty.TextChanged += new System.EventHandler(this.tb_qty_change);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SE NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ITEM";
            // 
            // cb_item
            // 
            this.cb_item.FormattingEnabled = true;
            this.cb_item.Location = new System.Drawing.Point(113, 0);
            this.cb_item.Name = "cb_item";
            this.cb_item.Size = new System.Drawing.Size(129, 21);
            this.cb_item.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "QUANTITY";
            // 
            // tb_rate
            // 
            this.tb_rate.Location = new System.Drawing.Point(446, 0);
            this.tb_rate.Name = "tb_rate";
            this.tb_rate.Size = new System.Drawing.Size(72, 20);
            this.tb_rate.TabIndex = 0;
            this.tb_rate.TextChanged += new System.EventHandler(this.tb_rate_taxtChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "RATE";
            // 
            // tb_price
            // 
            this.tb_price.Enabled = false;
            this.tb_price.Location = new System.Drawing.Point(569, 0);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(75, 20);
            this.tb_price.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(524, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "PRICE";
            // 
            // tb_seno
            // 
            this.tb_seno.Enabled = false;
            this.tb_seno.Location = new System.Drawing.Point(35, 0);
            this.tb_seno.Name = "tb_seno";
            this.tb_seno.Size = new System.Drawing.Size(33, 20);
            this.tb_seno.TabIndex = 0;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.cb_item);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_seno);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_rate);
            this.Controls.Add(this.tb_qtty);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(645, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_qtty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_item;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_rate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tb_seno;
    }
}
