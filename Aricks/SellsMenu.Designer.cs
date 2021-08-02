
namespace Aricks
{
    partial class SellsMenu
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
            this.btn_Quite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Quite
            // 
            this.btn_Quite.BackColor = System.Drawing.Color.Red;
            this.btn_Quite.Location = new System.Drawing.Point(704, 0);
            this.btn_Quite.Name = "btn_Quite";
            this.btn_Quite.Size = new System.Drawing.Size(30, 23);
            this.btn_Quite.TabIndex = 1;
            this.btn_Quite.Text = "X";
            this.btn_Quite.UseVisualStyleBackColor = false;
            this.btn_Quite.Click += new System.EventHandler(this.btn_Quite_Click);
            // 
            // SellsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.Controls.Add(this.btn_Quite);
            this.Name = "SellsMenu";
            this.Size = new System.Drawing.Size(734, 478);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Quite;
    }
}
