
namespace Aricks
{
    partial class BuyMenu
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
            this.titel_panel_buy = new System.Windows.Forms.Panel();
            this.btn_quite = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.btn_buy_add = new System.Windows.Forms.Button();
            this.titel_panel_buy.SuspendLayout();
            this.SuspendLayout();
            // 
            // titel_panel_buy
            // 
            this.titel_panel_buy.BackColor = System.Drawing.Color.Blue;
            this.titel_panel_buy.Controls.Add(this.btn_quite);
            this.titel_panel_buy.Controls.Add(this.title);
            this.titel_panel_buy.Dock = System.Windows.Forms.DockStyle.Top;
            this.titel_panel_buy.Location = new System.Drawing.Point(0, 0);
            this.titel_panel_buy.Name = "titel_panel_buy";
            this.titel_panel_buy.Size = new System.Drawing.Size(663, 46);
            this.titel_panel_buy.TabIndex = 6;
            // 
            // btn_quite
            // 
            this.btn_quite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_quite.BackgroundImage = global::Aricks.Properties.Resources.dialog_close;
            this.btn_quite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_quite.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_quite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quite.Location = new System.Drawing.Point(615, 0);
            this.btn_quite.Name = "btn_quite";
            this.btn_quite.Size = new System.Drawing.Size(48, 46);
            this.btn_quite.TabIndex = 5;
            this.btn_quite.UseVisualStyleBackColor = true;
            this.btn_quite.Click += new System.EventHandler(this.btn_quite_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.title.Font = new System.Drawing.Font("Algerian", 29F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.title.ForeColor = System.Drawing.Color.MintCream;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.title.Size = new System.Drawing.Size(373, 44);
            this.title.TabIndex = 4;
            this.title.Text = "Manage Vendors";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_buy_add
            // 
            this.btn_buy_add.Location = new System.Drawing.Point(291, 141);
            this.btn_buy_add.Name = "btn_buy_add";
            this.btn_buy_add.Size = new System.Drawing.Size(137, 23);
            this.btn_buy_add.TabIndex = 7;
            this.btn_buy_add.Text = "ADD NEW BUY";
            this.btn_buy_add.UseVisualStyleBackColor = true;
            this.btn_buy_add.Click += new System.EventHandler(this.btn_buy_add_Click);
            // 
            // BuyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btn_buy_add);
            this.Controls.Add(this.titel_panel_buy);
            this.Name = "BuyMenu";
            this.Size = new System.Drawing.Size(663, 364);
            this.titel_panel_buy.ResumeLayout(false);
            this.titel_panel_buy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titel_panel_buy;
        private System.Windows.Forms.Button btn_quite;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btn_buy_add;
    }
}
