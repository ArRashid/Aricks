
namespace Aricks
{
    partial class UserControl1
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
            this.btn_addac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addac
            // 
            this.btn_addac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addac.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_addac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addac.Image = global::Aricks.Properties.Resources._893;
            this.btn_addac.Location = new System.Drawing.Point(0, 0);
            this.btn_addac.Name = "btn_addac";
            this.btn_addac.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_addac.Size = new System.Drawing.Size(504, 132);
            this.btn_addac.TabIndex = 1;
            this.btn_addac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_addac.UseVisualStyleBackColor = true;
            this.btn_addac.Click += new System.EventHandler(this.btn_addac_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.Controls.Add(this.btn_addac);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(504, 229);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addac;
    }
}
