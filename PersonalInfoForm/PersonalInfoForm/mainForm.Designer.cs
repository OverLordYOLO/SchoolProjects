namespace PersonalInfoForm
{
    partial class mainForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emailRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.surnameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.nameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // emailRichTextBox
            // 
            this.emailRichTextBox.Location = new System.Drawing.Point(92, 120);
            this.emailRichTextBox.MaxLength = 60;
            this.emailRichTextBox.Name = "emailRichTextBox";
            this.emailRichTextBox.ReadOnly = true;
            this.emailRichTextBox.Size = new System.Drawing.Size(255, 30);
            this.emailRichTextBox.TabIndex = 11;
            this.emailRichTextBox.Text = "";
            // 
            // ageRichTextBox
            // 
            this.ageRichTextBox.Location = new System.Drawing.Point(92, 84);
            this.ageRichTextBox.MaxLength = 3;
            this.ageRichTextBox.Name = "ageRichTextBox";
            this.ageRichTextBox.ReadOnly = true;
            this.ageRichTextBox.Size = new System.Drawing.Size(66, 30);
            this.ageRichTextBox.TabIndex = 10;
            this.ageRichTextBox.Text = "";
            // 
            // surnameRichTextBox
            // 
            this.surnameRichTextBox.Location = new System.Drawing.Point(92, 48);
            this.surnameRichTextBox.MaxLength = 40;
            this.surnameRichTextBox.Name = "surnameRichTextBox";
            this.surnameRichTextBox.ReadOnly = true;
            this.surnameRichTextBox.Size = new System.Drawing.Size(161, 30);
            this.surnameRichTextBox.TabIndex = 9;
            this.surnameRichTextBox.Text = "";
            // 
            // nameRichTextBox
            // 
            this.nameRichTextBox.Location = new System.Drawing.Point(92, 12);
            this.nameRichTextBox.MaxLength = 40;
            this.nameRichTextBox.Name = "nameRichTextBox";
            this.nameRichTextBox.ReadOnly = true;
            this.nameRichTextBox.Size = new System.Drawing.Size(161, 30);
            this.nameRichTextBox.TabIndex = 8;
            this.nameRichTextBox.Text = "";
            // 
            // InfoDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 172);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailRichTextBox);
            this.Controls.Add(this.ageRichTextBox);
            this.Controls.Add(this.surnameRichTextBox);
            this.Controls.Add(this.nameRichTextBox);
            this.Name = "InfoDisplayForm";
            this.Text = "InfoDisplayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox emailRichTextBox;
        private System.Windows.Forms.RichTextBox ageRichTextBox;
        private System.Windows.Forms.RichTextBox surnameRichTextBox;
        private System.Windows.Forms.RichTextBox nameRichTextBox;
    }
}