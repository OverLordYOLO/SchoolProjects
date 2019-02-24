﻿namespace PersonalInfoForm
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
            this.ageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.emailRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.invalidCharacterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameRichTextBox
            // 
            this.nameRichTextBox.Location = new System.Drawing.Point(94, 12);
            this.nameRichTextBox.MaxLength = 40;
            this.nameRichTextBox.Name = "nameRichTextBox";
            this.nameRichTextBox.Size = new System.Drawing.Size(161, 30);
            this.nameRichTextBox.TabIndex = 0;
            this.nameRichTextBox.Text = "";
            // 
            // surnameRichTextBox
            // 
            this.surnameRichTextBox.Location = new System.Drawing.Point(94, 48);
            this.surnameRichTextBox.MaxLength = 40;
            this.surnameRichTextBox.Name = "surnameRichTextBox";
            this.surnameRichTextBox.Size = new System.Drawing.Size(161, 30);
            this.surnameRichTextBox.TabIndex = 1;
            this.surnameRichTextBox.Text = "";
            // 
            // ageRichTextBox
            // 
            this.ageRichTextBox.Location = new System.Drawing.Point(94, 84);
            this.ageRichTextBox.MaxLength = 3;
            this.ageRichTextBox.Name = "ageRichTextBox";
            this.ageRichTextBox.Size = new System.Drawing.Size(66, 30);
            this.ageRichTextBox.TabIndex = 2;
            this.ageRichTextBox.Text = "";
            // 
            // emailRichTextBox
            // 
            this.emailRichTextBox.Location = new System.Drawing.Point(94, 120);
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
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age";
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
            this.submitButton.Location = new System.Drawing.Point(272, 12);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(147, 53);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // invalidCharacterLabel
            // 
            this.invalidCharacterLabel.AutoSize = true;
            this.invalidCharacterLabel.Location = new System.Drawing.Point(12, 168);
            this.invalidCharacterLabel.Name = "invalidCharacterLabel";
            this.invalidCharacterLabel.Size = new System.Drawing.Size(0, 17);
            this.invalidCharacterLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 203);
            this.Controls.Add(this.invalidCharacterLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailRichTextBox);
            this.Controls.Add(this.ageRichTextBox);
            this.Controls.Add(this.surnameRichTextBox);
            this.Controls.Add(this.nameRichTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox nameRichTextBox;
        private System.Windows.Forms.RichTextBox surnameRichTextBox;
        private System.Windows.Forms.RichTextBox ageRichTextBox;
        private System.Windows.Forms.RichTextBox emailRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label invalidCharacterLabel;
    }
}

