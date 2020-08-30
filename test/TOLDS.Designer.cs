namespace test
{
    partial class TOLDS
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
            this.danhsanhdexuat_listCheckbox = new System.Windows.Forms.CheckedListBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // danhsanhdexuat_listCheckbox
            // 
            this.danhsanhdexuat_listCheckbox.FormattingEnabled = true;
            this.danhsanhdexuat_listCheckbox.Location = new System.Drawing.Point(22, 27);
            this.danhsanhdexuat_listCheckbox.Name = "danhsanhdexuat_listCheckbox";
            this.danhsanhdexuat_listCheckbox.Size = new System.Drawing.Size(240, 364);
            this.danhsanhdexuat_listCheckbox.TabIndex = 0;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(187, 415);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 1;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // TOLDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.danhsanhdexuat_listCheckbox);
            this.Name = "TOLDS";
            this.Text = "TOLDS";
            this.Load += new System.EventHandler(this.TOLDS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox danhsanhdexuat_listCheckbox;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label label1;
    }
}