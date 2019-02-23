namespace trafficLight
{
    partial class LightDisplayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LightDisplayForm));
            this.stopPictureBox = new System.Windows.Forms.PictureBox();
            this.attentionPictureBox = new System.Windows.Forms.PictureBox();
            this.goPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.stopPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attentionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // stopPictureBox
            // 
            this.stopPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.stopPictureBox.InitialImage = null;
            this.stopPictureBox.Location = new System.Drawing.Point(18, 2);
            this.stopPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.stopPictureBox.Name = "stopPictureBox";
            this.stopPictureBox.Size = new System.Drawing.Size(120, 120);
            this.stopPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stopPictureBox.TabIndex = 1;
            this.stopPictureBox.TabStop = false;
            this.stopPictureBox.Click += new System.EventHandler(this.stopPictureBox_Click);
            // 
            // attentionPictureBox
            // 
            this.attentionPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.attentionPictureBox.InitialImage = null;
            this.attentionPictureBox.Location = new System.Drawing.Point(18, 122);
            this.attentionPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.attentionPictureBox.Name = "attentionPictureBox";
            this.attentionPictureBox.Size = new System.Drawing.Size(120, 120);
            this.attentionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.attentionPictureBox.TabIndex = 2;
            this.attentionPictureBox.TabStop = false;
            // 
            // goPictureBox
            // 
            this.goPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.goPictureBox.InitialImage = null;
            this.goPictureBox.Location = new System.Drawing.Point(18, 242);
            this.goPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.goPictureBox.Name = "goPictureBox";
            this.goPictureBox.Size = new System.Drawing.Size(120, 120);
            this.goPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goPictureBox.TabIndex = 3;
            this.goPictureBox.TabStop = false;
            this.goPictureBox.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // LightDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(134, 399);
            this.ControlBox = false;
            this.Controls.Add(this.goPictureBox);
            this.Controls.Add(this.attentionPictureBox);
            this.Controls.Add(this.stopPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LightDisplayForm";
            this.ShowIcon = false;
            this.Text = "lightDisplay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LightDisplayForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.stopPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attentionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox stopPictureBox;
        private System.Windows.Forms.PictureBox attentionPictureBox;
        private System.Windows.Forms.PictureBox goPictureBox;
    }
}