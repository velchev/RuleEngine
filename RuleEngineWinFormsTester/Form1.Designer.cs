namespace RuleEngineWinFormsTester
{
    partial class Form1
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
            this.chkListAnswers = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // chkListAnswers
            // 
            this.chkListAnswers.FormattingEnabled = true;
            this.chkListAnswers.Location = new System.Drawing.Point(77, 133);
            this.chkListAnswers.Name = "chkListAnswers";
            this.chkListAnswers.Size = new System.Drawing.Size(331, 154);
            this.chkListAnswers.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 405);
            this.Controls.Add(this.chkListAnswers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkListAnswers;
    }
}

