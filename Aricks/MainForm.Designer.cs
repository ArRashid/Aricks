
namespace Aricks
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.btn_account = new System.Windows.Forms.Button();
            this.btn_main = new System.Windows.Forms.Button();
            this.icon = new System.Windows.Forms.PictureBox();
            this.content_panel = new System.Windows.Forms.Panel();
            this.menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.DarkGray;
            this.menu_panel.Controls.Add(this.button2);
            this.menu_panel.Controls.Add(this.btn_Buy);
            this.menu_panel.Controls.Add(this.btn_account);
            this.menu_panel.Controls.Add(this.btn_main);
            this.menu_panel.Controls.Add(this.icon);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_panel.Location = new System.Drawing.Point(0, 24);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(150, 404);
            this.menu_panel.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(0, 200);
            this.button2.MinimumSize = new System.Drawing.Size(0, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sells";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_Sells_click);
            // 
            // btn_Buy
            // 
            this.btn_Buy.AutoSize = true;
            this.btn_Buy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Buy.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Buy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Buy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Buy.Location = new System.Drawing.Point(0, 150);
            this.btn_Buy.MinimumSize = new System.Drawing.Size(0, 50);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(150, 50);
            this.btn_Buy.TabIndex = 4;
            this.btn_Buy.Text = "Buy";
            this.btn_Buy.UseVisualStyleBackColor = false;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // btn_account
            // 
            this.btn_account.AutoSize = true;
            this.btn_account.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_account.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_account.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_account.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_account.Location = new System.Drawing.Point(0, 100);
            this.btn_account.MinimumSize = new System.Drawing.Size(0, 50);
            this.btn_account.Name = "btn_account";
            this.btn_account.Size = new System.Drawing.Size(150, 50);
            this.btn_account.TabIndex = 3;
            this.btn_account.Text = "Account";
            this.btn_account.UseVisualStyleBackColor = false;
            this.btn_account.Click += new System.EventHandler(this.btn_account_Click);
            // 
            // btn_main
            // 
            this.btn_main.AutoSize = true;
            this.btn_main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_main.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_main.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_main.Location = new System.Drawing.Point(0, 50);
            this.btn_main.MinimumSize = new System.Drawing.Size(0, 50);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(150, 50);
            this.btn_main.TabIndex = 2;
            this.btn_main.Text = "Main";
            this.btn_main.UseVisualStyleBackColor = false;
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.icon.Dock = System.Windows.Forms.DockStyle.Top;
            this.icon.Location = new System.Drawing.Point(0, 0);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(150, 50);
            this.icon.TabIndex = 1;
            this.icon.TabStop = false;
            // 
            // content_panel
            // 
            this.content_panel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.content_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_panel.Location = new System.Drawing.Point(150, 24);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(650, 404);
            this.content_panel.TabIndex = 3;
            this.content_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.content_panel_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.content_panel);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aricks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel menu_panel;
        public System.Windows.Forms.Panel content_panel;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Buy;
        private System.Windows.Forms.Button btn_account;
    }
}

