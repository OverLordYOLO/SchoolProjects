namespace PersonalInfoForm
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
            this.nameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.surnameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.emailRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // nameRichTextBox
            // 
            this.nameRichTextBox.Location = new System.Drawing.Point(105, 12);
            this.nameRichTextBox.MaxLength = 40;
            this.nameRichTextBox.Name = "nameRichTextBox";
            this.nameRichTextBox.Size = new System.Drawing.Size(161, 30);
            this.nameRichTextBox.TabIndex = 0;
            this.nameRichTextBox.Text = "";
            // 
            // surnameRichTextBox
            // 
            this.surnameRichTextBox.Location = new System.Drawing.Point(105, 48);
            this.surnameRichTextBox.MaxLength = 40;
            this.surnameRichTextBox.Name = "surnameRichTextBox";
            this.surnameRichTextBox.Size = new System.Drawing.Size(161, 30);
            this.surnameRichTextBox.TabIndex = 1;
            this.surnameRichTextBox.Text = "";
            // 
            // emailRichTextBox
            // 
            this.emailRichTextBox.Location = new System.Drawing.Point(105, 120);
            this.emailRichTextBox.MaxLength = 60;
            this.emailRichTextBox.Name = "emailRichTextBox";
            this.emailRichTextBox.Size = new System.Drawing.Size(255, 30);
            this.emailRichTextBox.TabIndex = 3;
            this.emailRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(280, 12);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(147, 53);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(18, 168);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 17);
            this.infoLabel.TabIndex = 10;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(105, 87);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(161, 22);
            this.dateTimePicker.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 203);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailRichTextBox);
            this.Controls.Add(this.surnameRichTextBox);
            this.Controls.Add(this.nameRichTextBox);
            this.Name = "MainForm";
            this.Text = "Information Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox nameRichTextBox;
        private System.Windows.Forms.RichTextBox surnameRichTextBox;
        private System.Windows.Forms.RichTextBox emailRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}

