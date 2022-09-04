namespace WinFormsApp1
{
    partial class Email
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
            this.SendBT = new System.Windows.Forms.Button();
            this.SendToTB = new System.Windows.Forms.TextBox();
            this.SubjTB = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SendTo = new System.Windows.Forms.Label();
            this.Subj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendBT
            // 
            this.SendBT.Location = new System.Drawing.Point(292, 45);
            this.SendBT.Name = "SendBT";
            this.SendBT.Size = new System.Drawing.Size(94, 29);
            this.SendBT.TabIndex = 0;
            this.SendBT.Text = "Send";
            this.SendBT.UseVisualStyleBackColor = true;
            this.SendBT.Click += new System.EventHandler(this.SendBT_Click);
            // 
            // SendToTB
            // 
            this.SendToTB.Location = new System.Drawing.Point(111, 45);
            this.SendToTB.Name = "SendToTB";
            this.SendToTB.Size = new System.Drawing.Size(157, 27);
            this.SendToTB.TabIndex = 1;
            // 
            // SubjTB
            // 
            this.SubjTB.Location = new System.Drawing.Point(111, 78);
            this.SubjTB.Name = "SubjTB";
            this.SubjTB.Size = new System.Drawing.Size(157, 27);
            this.SubjTB.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(111, 144);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(683, 348);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // SendTo
            // 
            this.SendTo.AutoSize = true;
            this.SendTo.Location = new System.Drawing.Point(12, 49);
            this.SendTo.Name = "SendTo";
            this.SendTo.Size = new System.Drawing.Size(65, 20);
            this.SendTo.TabIndex = 4;
            this.SendTo.Text = "Send To:";
            // 
            // Subj
            // 
            this.Subj.AutoSize = true;
            this.Subj.Location = new System.Drawing.Point(12, 81);
            this.Subj.Name = "Subj";
            this.Subj.Size = new System.Drawing.Size(61, 20);
            this.Subj.TabIndex = 5;
            this.Subj.Text = "Subject:";
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 504);
            this.Controls.Add(this.Subj);
            this.Controls.Add(this.SendTo);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SubjTB);
            this.Controls.Add(this.SendToTB);
            this.Controls.Add(this.SendBT);
            this.Name = "Email";
            this.Text = "Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SendBT;
        private TextBox SendToTB;
        private TextBox SubjTB;
        private RichTextBox richTextBox1;
        private Label SendTo;
        private Label Subj;
    }
}