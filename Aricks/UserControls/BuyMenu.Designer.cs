
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
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_quite = new System.Windows.Forms.Button();
            this.menu_holder_panel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_edite_account = new System.Windows.Forms.Button();
            this.btn_buy_add = new System.Windows.Forms.Button();
            this.titel_panel_buy.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menu_holder_panel.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 318);
            this.panel1.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.menu_holder_panel);
            this.splitContainer1.Size = new System.Drawing.Size(663, 318);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.TabIndex = 0;
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
            // menu_holder_panel
            // 
            this.menu_holder_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menu_holder_panel.BackColor = System.Drawing.Color.DodgerBlue;
            this.menu_holder_panel.Controls.Add(this.button3);
            this.menu_holder_panel.Controls.Add(this.btn_edite_account);
            this.menu_holder_panel.Controls.Add(this.btn_buy_add);
            this.menu_holder_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_holder_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_holder_panel.Name = "menu_holder_panel";
            this.menu_holder_panel.Size = new System.Drawing.Size(221, 318);
            this.menu_holder_panel.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Aricks.Properties.Resources.btn_style_black;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Javanese Text", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Image = global::Aricks.Properties.Resources.meeting_participant_no_response;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 80);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete Account";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_edite_account
            // 
            this.btn_edite_account.BackgroundImage = global::Aricks.Properties.Resources.btn_style_black;
            this.btn_edite_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edite_account.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_edite_account.FlatAppearance.BorderSize = 0;
            this.btn_edite_account.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_edite_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edite_account.Font = new System.Drawing.Font("Javanese Text", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_edite_account.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_edite_account.Image = global::Aricks.Properties.Resources.user_group_properties;
            this.btn_edite_account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edite_account.Location = new System.Drawing.Point(0, 80);
            this.btn_edite_account.Name = "btn_edite_account";
            this.btn_edite_account.Size = new System.Drawing.Size(221, 80);
            this.btn_edite_account.TabIndex = 1;
            this.btn_edite_account.Text = "Edite Account";
            this.btn_edite_account.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_edite_account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_edite_account.UseVisualStyleBackColor = true;
            // 
            // btn_buy_add
            // 
            this.btn_buy_add.BackgroundImage = global::Aricks.Properties.Resources.btn_style_black;
            this.btn_buy_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buy_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_buy_add.FlatAppearance.BorderSize = 0;
            this.btn_buy_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_buy_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy_add.Font = new System.Drawing.Font("Javanese Text", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_buy_add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_buy_add.Image = global::Aricks.Properties.Resources.mail_mark_task;
            this.btn_buy_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buy_add.Location = new System.Drawing.Point(0, 0);
            this.btn_buy_add.Name = "btn_buy_add";
            this.btn_buy_add.Size = new System.Drawing.Size(221, 80);
            this.btn_buy_add.TabIndex = 0;
            this.btn_buy_add.Text = "New Buy Entry";
            this.btn_buy_add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_buy_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buy_add.UseVisualStyleBackColor = true;
            this.btn_buy_add.Click += new System.EventHandler(this.btn_buy_add_Click);
            // 
            // BuyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titel_panel_buy);
            this.Name = "BuyMenu";
            this.Size = new System.Drawing.Size(663, 364);
            this.titel_panel_buy.ResumeLayout(false);
            this.titel_panel_buy.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menu_holder_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titel_panel_buy;
        private System.Windows.Forms.Button btn_quite;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel menu_holder_panel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_edite_account;
        private System.Windows.Forms.Button btn_buy_add;
    }
}
