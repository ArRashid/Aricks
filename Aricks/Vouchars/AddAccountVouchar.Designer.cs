
namespace Aricks
{
    partial class AddAccountVouchar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccountVouchar));
            this.ac_vou_panel = new System.Windows.Forms.Panel();
            this.cb_ac_type = new System.Windows.Forms.ComboBox();
            this.acTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Aricks.databaseDataSet();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_bank_ifc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_bank_ac = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_mobile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_last_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_frist_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_opening_balance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ac_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.acTypeTableAdapter = new Aricks.databaseDataSetTableAdapters.AcTypeTableAdapter();
            this.ac_vou_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ac_vou_panel
            // 
            this.ac_vou_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ac_vou_panel.AutoScroll = true;
            this.ac_vou_panel.BackColor = System.Drawing.SystemColors.Info;
            this.ac_vou_panel.Controls.Add(this.cb_ac_type);
            this.ac_vou_panel.Controls.Add(this.label11);
            this.ac_vou_panel.Controls.Add(this.tb_bank_ifc);
            this.ac_vou_panel.Controls.Add(this.label9);
            this.ac_vou_panel.Controls.Add(this.label1);
            this.ac_vou_panel.Controls.Add(this.tb_bank_ac);
            this.ac_vou_panel.Controls.Add(this.label10);
            this.ac_vou_panel.Controls.Add(this.tb_address);
            this.ac_vou_panel.Controls.Add(this.label8);
            this.ac_vou_panel.Controls.Add(this.tb_email);
            this.ac_vou_panel.Controls.Add(this.label6);
            this.ac_vou_panel.Controls.Add(this.tb_mobile);
            this.ac_vou_panel.Controls.Add(this.label7);
            this.ac_vou_panel.Controls.Add(this.tb_last_name);
            this.ac_vou_panel.Controls.Add(this.label5);
            this.ac_vou_panel.Controls.Add(this.tb_frist_name);
            this.ac_vou_panel.Controls.Add(this.label3);
            this.ac_vou_panel.Controls.Add(this.tb_opening_balance);
            this.ac_vou_panel.Controls.Add(this.label4);
            this.ac_vou_panel.Controls.Add(this.tb_ac_id);
            this.ac_vou_panel.Controls.Add(this.label2);
            this.ac_vou_panel.Location = new System.Drawing.Point(12, 24);
            this.ac_vou_panel.MaximumSize = new System.Drawing.Size(776, 361);
            this.ac_vou_panel.Name = "ac_vou_panel";
            this.ac_vou_panel.Size = new System.Drawing.Size(776, 361);
            this.ac_vou_panel.TabIndex = 0;
            // 
            // cb_ac_type
            // 
            this.cb_ac_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_ac_type.DataSource = this.acTypeBindingSource;
            this.cb_ac_type.DisplayMember = "type";
            this.cb_ac_type.FormattingEnabled = true;
            this.cb_ac_type.Location = new System.Drawing.Point(504, 75);
            this.cb_ac_type.Name = "cb_ac_type";
            this.cb_ac_type.Size = new System.Drawing.Size(203, 21);
            this.cb_ac_type.TabIndex = 1;
            // 
            // acTypeBindingSource
            // 
            this.acTypeBindingSource.DataMember = "AcType";
            this.acTypeBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(414, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "A/c Type :";
            // 
            // tb_bank_ifc
            // 
            this.tb_bank_ifc.Location = new System.Drawing.Point(504, 195);
            this.tb_bank_ifc.Name = "tb_bank_ifc";
            this.tb_bank_ifc.Size = new System.Drawing.Size(203, 20);
            this.tb_bank_ifc.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(416, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Bank IFC :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add  Account Vouchar";
            // 
            // tb_bank_ac
            // 
            this.tb_bank_ac.Location = new System.Drawing.Point(145, 195);
            this.tb_bank_ac.Name = "tb_bank_ac";
            this.tb_bank_ac.Size = new System.Drawing.Size(203, 20);
            this.tb_bank_ac.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(57, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Bank A/c :";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(145, 271);
            this.tb_address.Multiline = true;
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(562, 70);
            this.tb_address.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(62, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Address :";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(504, 152);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(203, 20);
            this.tb_email.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(439, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email :";
            // 
            // tb_mobile
            // 
            this.tb_mobile.Location = new System.Drawing.Point(145, 156);
            this.tb_mobile.MaxLength = 10;
            this.tb_mobile.Name = "tb_mobile";
            this.tb_mobile.Size = new System.Drawing.Size(203, 20);
            this.tb_mobile.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(78, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mobie :";
            // 
            // tb_last_name
            // 
            this.tb_last_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_last_name.Location = new System.Drawing.Point(504, 113);
            this.tb_last_name.MaxLength = 100;
            this.tb_last_name.Name = "tb_last_name";
            this.tb_last_name.Size = new System.Drawing.Size(203, 20);
            this.tb_last_name.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(403, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Last Name :";
            // 
            // tb_frist_name
            // 
            this.tb_frist_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_frist_name.Location = new System.Drawing.Point(145, 114);
            this.tb_frist_name.MaxLength = 100;
            this.tb_frist_name.Name = "tb_frist_name";
            this.tb_frist_name.Size = new System.Drawing.Size(203, 20);
            this.tb_frist_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(43, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Frist Name :";
            // 
            // tb_opening_balance
            // 
            this.tb_opening_balance.Location = new System.Drawing.Point(283, 234);
            this.tb_opening_balance.Name = "tb_opening_balance";
            this.tb_opening_balance.Size = new System.Drawing.Size(424, 20);
            this.tb_opening_balance.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(142, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Opening Balnace :";
            // 
            // tb_ac_id
            // 
            this.tb_ac_id.Location = new System.Drawing.Point(145, 78);
            this.tb_ac_id.MaxLength = 10;
            this.tb_ac_id.Name = "tb_ac_id";
            this.tb_ac_id.Size = new System.Drawing.Size(203, 20);
            this.tb_ac_id.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(78, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "A/c ID :";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(514, 415);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(95, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(633, 415);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(95, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // acTypeTableAdapter
            // 
            this.acTypeTableAdapter.ClearBeforeFill = true;
            // 
            // AddAccountVouchar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.ac_vou_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAccountVouchar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddAccount";
            this.Load += new System.EventHandler(this.AddAccountVouchar_Load);
            this.ac_vou_panel.ResumeLayout(false);
            this.ac_vou_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ac_vou_panel;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_mobile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_last_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_frist_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_opening_balance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ac_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_bank_ifc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_bank_ac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ComboBox cb_ac_type;
        private System.Windows.Forms.Label label11;
        private databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource acTypeBindingSource;
        private databaseDataSetTableAdapters.AcTypeTableAdapter acTypeTableAdapter;
    }
}