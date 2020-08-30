namespace test
{
    partial class vote_form
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
            this.list_candidate = new System.Windows.Forms.CheckedListBox();
            this.candidates = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_candidate
            // 
            this.list_candidate.FormattingEnabled = true;
            this.list_candidate.Location = new System.Drawing.Point(329, 67);
            this.list_candidate.Name = "list_candidate";
            this.list_candidate.Size = new System.Drawing.Size(423, 259);
            this.list_candidate.TabIndex = 0;
            // 
            // candidates
            // 
            this.candidates.AutoSize = true;
            this.candidates.Location = new System.Drawing.Point(326, 33);
            this.candidates.Name = "candidates";
            this.candidates.Size = new System.Drawing.Size(60, 13);
            this.candidates.TabIndex = 1;
            this.candidates.Text = "Candidates";
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(677, 361);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 2;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // vote_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.candidates);
            this.Controls.Add(this.list_candidate);
            this.Name = "vote_form";
            this.Text = "vote_form";
            this.Load += new System.EventHandler(this.vote_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox list_candidate;
        private System.Windows.Forms.Label candidates;
        private System.Windows.Forms.Button confirm;
    }
}